﻿#if NETSTANDARD2_1 || NET9_0_OR_GREATER
#if NET9_0_OR_GREATER
using System;
#endif
using System.IO.Compression;
#if NET9_0_OR_GREATER

using WebMarkupMin.AspNet.Common.Resources;
#endif

namespace WebMarkupMin.AspNet.Common.Compressors
{
	/// <summary>
	/// Brotli compression settings
	/// </summary>
	public sealed class BuiltInBrotliCompressionSettings
	{
#if NET9_0_OR_GREATER
		/// <summary>
		/// The minimum compression level
		/// </summary>
		private const int MIN_ALT_COMPRESSION_LEVEL = 0;

		/// <summary>
		/// The maximum compression level
		/// </summary>
		private const int MAX_ALT_COMPRESSION_LEVEL = 11;

		/// <summary>
		/// Compression options
		/// </summary>
		private BrotliCompressionOptions _options = new();

#endif
		/// <summary>
		/// Gets or sets a compression level
		/// </summary>
		public CompressionLevel Level
		{
#if NET9_0_OR_GREATER
			get
			{
				return ConvertCompressionLevelNumberToEnum(_options.Quality);
			}
			set
			{
				_options.Quality = ConvertCompressionLevelEnumToNumber(value);
			}
#else
			get;
			set;
#endif
		}
#if NET9_0_OR_GREATER

		/// <summary>
		/// Gets or sets a alternative compression level
		/// </summary>
		/// <remarks>
		/// The higher the level, the slower the compression. Range is from 0 to 11. The default value is 4.
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">The value is less than 0 or greater than 11.</exception>
		public int AlternativeLevel
		{
			get
			{
				return _options.Quality;
			}
			set
			{
				if (value < MIN_ALT_COMPRESSION_LEVEL || value > MAX_ALT_COMPRESSION_LEVEL)
				{
					throw new ArgumentOutOfRangeException(
						nameof(value),
						string.Format(Strings.AlternativeCompressionLevelOutOfRange,
							MIN_ALT_COMPRESSION_LEVEL, MAX_ALT_COMPRESSION_LEVEL)
					);
				}

				_options.Quality = value;
			}
		}
#endif


		/// <summary>
		/// Constructs an instance of the brotli compression settings
		/// </summary>
		public BuiltInBrotliCompressionSettings()
		{
			Level = CompressionLevel.Optimal;
		}
#if NET9_0_OR_GREATER


		/// <summary>
		/// Converts a enum representation of the compression level to a number
		/// </summary>
		/// <param name="level">Compression level represented as an enum</param>
		/// <returns>Compression level represented as a number</returns>
		/// <exception cref="NotSupportedException"/>
		private static int ConvertCompressionLevelEnumToNumber(CompressionLevel level)
		{
			int levelNumber;

			switch (level)
			{
				case CompressionLevel.NoCompression:
					levelNumber = MIN_ALT_COMPRESSION_LEVEL;
					break;
				case CompressionLevel.Fastest:
					levelNumber = 1;
					break;
				case CompressionLevel.Optimal:
					levelNumber = 4;
					break;
				case CompressionLevel.SmallestSize:
					levelNumber = MAX_ALT_COMPRESSION_LEVEL;
					break;
				default:
					throw new NotSupportedException();
			}

			return levelNumber;
		}

		/// <summary>
		/// Converts a numeric representation of the compression level to an enum
		/// </summary>
		/// <param name="level">Compression level represented as a number</param>
		/// <returns>Compression level represented as an enum</returns>
		/// <exception cref="NotSupportedException"/>
		private static CompressionLevel ConvertCompressionLevelNumberToEnum(int level)
		{
			CompressionLevel levelEnum;

			switch (level)
			{
				case MIN_ALT_COMPRESSION_LEVEL:
					levelEnum = CompressionLevel.NoCompression;
					break;
				case 1:
				case 2:
					levelEnum = CompressionLevel.Fastest;
					break;
				case int n when n >= 3 && n <= 9:
					levelEnum = CompressionLevel.Optimal;
					break;
				case 10:
				case MAX_ALT_COMPRESSION_LEVEL:
					levelEnum = CompressionLevel.SmallestSize;
					break;
				default:
					throw new NotSupportedException();
			}

			return levelEnum;
		}


		/// <summary>
		/// Gets a compression options
		/// </summary>
		/// <returns>Compression options</returns>
		internal BrotliCompressionOptions GetOptions()
		{
			return _options;
		}
#endif
	}
}
#endif