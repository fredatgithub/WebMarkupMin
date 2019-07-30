﻿using System;
using System.IO;
using System.IO.Compression;
#if !NETSTANDARD2_1

using BrotliSharpLib;
#endif

using WebMarkupMin.AspNet.Common.Compressors;

namespace WebMarkupMin.AspNet.Brotli
{
	/// <summary>
	/// Brotli compressor
	/// </summary>
	public sealed class BrotliCompressor : ICompressor
	{
		/// <summary>
		/// Encoding token of compressor
		/// </summary>
		public const string CompressorEncodingToken = "br";

		/// <summary>
		/// Brotli compression settings
		/// </summary>
		private readonly BrotliCompressionSettings _settings;

		/// <summary>
		/// Gets a encoding token
		/// </summary>
		public string EncodingToken
		{
			get { return CompressorEncodingToken; }
		}

		/// <summary>
		/// Gets a value that indicates if the compressor supports flushing
		/// </summary>
		public bool SupportsFlush
		{
			get { return true; }
		}


		/// <summary>
		/// Constructs an instance of the brotli compressor
		/// </summary>
		public BrotliCompressor()
			: this(new BrotliCompressionSettings())
		{ }

		/// <summary>
		/// Constructs an instance of the brotli compressor
		/// </summary>
		/// <param name="settings">Brotli compression settings</param>
		public BrotliCompressor(BrotliCompressionSettings settings)
		{
			_settings = settings;
		}


		/// <summary>
		/// Compress a stream by brotli algorithm
		/// </summary>
		/// <param name="stream">The stream</param>
		/// <returns>The compressed stream</returns>
		public Stream Compress(Stream stream)
		{
#if NETSTANDARD2_1
			CompressionLevel compressionLevel;

			switch (_settings.Level)
			{
				case 0:
					compressionLevel = CompressionLevel.NoCompression;
					break;
				case 1:
				case 2:
					compressionLevel = CompressionLevel.Fastest;
					break;
				case int level when level >= 3 && level <= 11:
					compressionLevel = (CompressionLevel)level;
					break;
				default:
					throw new NotSupportedException();
			}

			var brotliStream = new BrotliStream(stream, compressionLevel);
#else
			var brotliStream = new BrotliStream(stream, CompressionMode.Compress);
			brotliStream.SetQuality(_settings.Level);
#endif

			return brotliStream;
		}
	}
}