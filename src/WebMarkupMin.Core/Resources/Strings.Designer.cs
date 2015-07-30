//------------------------------------------------------------------------------
// <auto-generated>
//	 This code was generated by a tool.
//
//	 Changes to this file may cause incorrect behavior and will be lost if
//	 the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace WebMarkupMin.Core.Resources
{
	using System;
	using System.Globalization;
	using System.Reflection;
	using System.Resources;

	/// <summary>
	/// A strongly-typed resource class, for looking up localized strings, etc.
	/// </summary>
	public class Strings
	{
		private static Lazy<ResourceManager> _resourceManager =
			new Lazy<ResourceManager>(() => new ResourceManager(
				"WebMarkupMin.Core.Resources.Strings",
#if DOTNET || NET || DNXCORE50 || DNX451
				typeof(Strings).GetTypeInfo().Assembly
#elif NET40
				typeof(Strings).Assembly
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
		/// Looks up a localized string similar to "You do not specified a name of assembly."
		/// </summary>
		public static string Common_AssemblyNameIsEmpty
		{
			get { return GetString("Common_AssemblyNameIsEmpty"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Can not convert value '{0}' of enumeration type '{1}' to value of enumeration type '{2}'."
		/// </summary>
		public static string Common_EnumValueConversionFailed
		{
			get { return GetString("Common_EnumValueConversionFailed"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "During instantiate an object of type '{0}' from assembly '{1}' error occurred."
		/// </summary>
		public static string Common_InstanceCreationFailed
		{
			get { return GetString("Common_InstanceCreationFailed"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "You do not specified a type name."
		/// </summary>
		public static string Common_TypeNameIsEmpty
		{
			get { return GetString("Common_TypeNameIsEmpty"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Value cannot be empty."
		/// </summary>
		public static string Common_ValueIsEmpty
		{
			get { return GetString("Common_ValueIsEmpty"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Value cannot be null."
		/// </summary>
		public static string Common_ValueIsNull
		{
			get { return GetString("Common_ValueIsNull"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "{0}-minifier with name '{1}' is not registered in configuration file."
		/// </summary>
		public static string Configuration_CodeMinifierNotRegistered
		{
			get { return GetString("Configuration_CodeMinifierNotRegistered"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Default {0}-minifier not specified."
		/// </summary>
		public static string Configuration_DefaultCodeMinifierNotSpecified
		{
			get { return GetString("Configuration_DefaultCodeMinifierNotSpecified"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Default logger not specified."
		/// </summary>
		public static string Configuration_DefaultLoggerNotSpecified
		{
			get { return GetString("Configuration_DefaultLoggerNotSpecified"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Logger with name '{0}' is not registered in configuration file."
		/// </summary>
		public static string Configuration_LoggerNotRegistered
		{
			get { return GetString("Configuration_LoggerNotRegistered"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Reloading of {0} minifier settings from the configuration file is prohibited."
		/// </summary>
		public static string Configuration_ReloadingCodeMinifierSettingsProhibited
		{
			get { return GetString("Configuration_ReloadingCodeMinifierSettingsProhibited"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Category"
		/// </summary>
		public static string ErrorDetails_Category
		{
			get { return GetString("ErrorDetails_Category"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Column number"
		/// </summary>
		public static string ErrorDetails_ColumnNumber
		{
			get { return GetString("ErrorDetails_ColumnNumber"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "File"
		/// </summary>
		public static string ErrorDetails_File
		{
			get { return GetString("ErrorDetails_File"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Line number"
		/// </summary>
		public static string ErrorDetails_LineNumber
		{
			get { return GetString("ErrorDetails_LineNumber"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Message"
		/// </summary>
		public static string ErrorDetails_Message
		{
			get { return GetString("ErrorDetails_Message"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Source fragment"
		/// </summary>
		public static string ErrorDetails_SourceFragment
		{
			get { return GetString("ErrorDetails_SourceFragment"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "During minification of {0} binding expression error has occurred: {1}."
		/// </summary>
		public static string ErrorMessage_BindingExpressionMinificationFailed
		{
			get { return GetString("ErrorMessage_BindingExpressionMinificationFailed"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "It is impossible to parse a &quot;End If conditional comment&quot;, because not declared &quot;If conditional..."
		/// </summary>
		public static string ErrorMessage_IfConditionalCommentNotDeclared
		{
			get { return GetString("ErrorMessage_IfConditionalCommentNotDeclared"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "In the start tag &lt;{0}&gt; found invalid characters."
		/// </summary>
		public static string ErrorMessage_InvalidCharactersInStartTag
		{
			get { return GetString("ErrorMessage_InvalidCharactersInStartTag"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "In the text node of XML document found invalid characters."
		/// </summary>
		public static string ErrorMessage_InvalidCharactersInXmlTextNode
		{
			get { return GetString("ErrorMessage_InvalidCharactersInXmlTextNode"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Type of &quot;End If conditional comment&quot; does not match to the type of openened &quot;If conditional..."
		/// </summary>
		public static string ErrorMessage_InvalidEndIfConditionalComment
		{
			get { return GetString("ErrorMessage_InvalidEndIfConditionalComment"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "During minification of {0}-code error has occurred: &quot;{1}&quot;."
		/// </summary>
		public static string ErrorMessage_MarkupMinificationFailed
		{
			get { return GetString("ErrorMessage_MarkupMinificationFailed"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "During parsing of {0}-code error has occurred."
		/// </summary>
		public static string ErrorMessage_MarkupParsingFailed
		{
			get { return GetString("ErrorMessage_MarkupParsingFailed"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Remain not closed conditional comment."
		/// </summary>
		public static string ErrorMessage_NotClosedConditionalComment
		{
			get { return GetString("ErrorMessage_NotClosedConditionalComment"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Tag &lt;{0}&gt; was not closed."
		/// </summary>
		public static string ErrorMessage_NotClosedTag
		{
			get { return GetString("ErrorMessage_NotClosedTag"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "It is impossible to render a end tag &lt;/{0}&gt;, because  start tag &lt;{0}&gt; not declared."
		/// </summary>
		public static string ErrorMessage_StartTagNotDeclared
		{
			get { return GetString("ErrorMessage_StartTagNotDeclared"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "An unknown error has occurred."
		/// </summary>
		public static string ErrorMessage_UnknownError
		{
			get { return GetString("ErrorMessage_UnknownError"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "During minification of the XML declaration error has occurred."
		/// </summary>
		public static string ErrorMessage_XmlDeclarationMinificationFailed
		{
			get { return GetString("ErrorMessage_XmlDeclarationMinificationFailed"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "Minification of the {0} code has been completed successfully."
		/// </summary>
		public static string SuccesMessage_MarkupMinificationComplete
		{
			get { return GetString("SuccesMessage_MarkupMinificationComplete"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "XML-based attribute {0} not allowed here. If you want to use the XHTML syntax, it is better to use..."
		/// </summary>
		public static string WarningMessage_XmlBasedAttributeNotAllowed
		{
			get { return GetString("WarningMessage_XmlBasedAttributeNotAllowed"); }
		}

		/// <summary>
		/// Looks up a localized string similar to "XML declaration not allowed here. If you want to use XHTML syntax, it is better to use the XHTML..."
		/// </summary>
		public static string WarningMessage_XmlDeclarationNotAllowed
		{
			get { return GetString("WarningMessage_XmlDeclarationNotAllowed"); }
		}

		private static string GetString(string name)
		{
			string value = ResourceManager.GetString(name, _resourceCulture);

			return value;
		}
	}
}