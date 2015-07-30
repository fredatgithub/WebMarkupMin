//------------------------------------------------------------------------------
// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace WebMarkupMin.Sample.Resources
{
	using System;
	using System.Globalization;
	using System.Reflection;
	using System.Resources;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	public class XmlMinificationStrings
	{
		private static Lazy<ResourceManager> _resourceManager =
			new Lazy<ResourceManager>(() => new ResourceManager(
				"WebMarkupMin.Sample.Resources.XmlMinificationStrings",
#if DOTNET || NET || DNXCORE50 || DNX451
				typeof(XmlMinificationStrings).GetTypeInfo().Assembly
#elif NET40
				typeof(XmlMinificationStrings).Assembly
#else
#error No implementation for this target
#endif
			));

		private static CultureInfo _resourceCulture;

		/// <summary>
		/// Returns a cached ResourceManager instance used by this class
		/// </summary>
		public static ResourceManager ResourceManager
		{
			get
			{
				return _resourceManager.Value;
			}
		}

		/// <summary>
		/// Overrides a current thread's CurrentUICulture property for all
		/// resource lookups using this strongly typed resource class
		/// </summary>
		public static CultureInfo Culture
		{
			get
			{
				return _resourceCulture;
			}
			set
			{
				_resourceCulture = value;
			}
		}

		/// <summary>
		/// Looks up a localized string similar to "Options"
		/// </summary>
		public static string ControlGroup_Options
		{
			get { return GetString("ControlGroup_Options"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Collapse tags without content"
		/// </summary>
		public static string DisplayName_CollapseTagsWithoutContent
		{
			get { return GetString("DisplayName_CollapseTagsWithoutContent"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Minify whitespace"
		/// </summary>
		public static string DisplayName_MinifyWhitespace
		{
			get { return GetString("DisplayName_MinifyWhitespace"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Remove XML comments"
		/// </summary>
		public static string DisplayName_RemoveXmlComments
		{
			get { return GetString("DisplayName_RemoveXmlComments"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Render empty tags with space"
		/// </summary>
		public static string DisplayName_RenderEmptyTagsWithSpace
		{
			get { return GetString("DisplayName_RenderEmptyTagsWithSpace"); }
		}

		private static string GetString(string name)
		{
			string value = ResourceManager.GetString(name, _resourceCulture);

			return value;
		}
	}
}