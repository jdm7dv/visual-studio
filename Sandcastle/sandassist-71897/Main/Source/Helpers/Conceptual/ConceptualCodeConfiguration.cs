﻿using System;
using System.Xml;
using System.Diagnostics;
using System.Collections.Generic;

using Sandcastle.Contents;
using Sandcastle.Utilities;

namespace Sandcastle.Conceptual
{
    [Serializable]
    public sealed class ConceptualCodeConfiguration : ConceptualComponentConfiguration
    {
        #region Public Fields

        /// <summary>
        /// Gets the unique name of this configuration.
        /// </summary>
        /// <value>
        /// A string specifying the unique name of this configuration.
        /// </value>
        public const string ConfigurationName =
            "Sandcastle.Conceptual.ConceptualCodeConfiguration";

        #endregion

        #region Private Fields

        private int    _tabSize;
        private bool   _showLineNumbers;
        private bool   _showOutlining;
        private bool   _highlightEnabled;
        private string _highlightMode;

        private string _snippetSeparator;
        private BuildCacheStorageType _snippetStorage;
 
        [NonSerialized]
        private BuildContext  _context;
        [NonSerialized]
        private BuildSettings _settings;

        #endregion

        #region Constructors and Destructor

        /// <overloads>
        /// Initializes a new instance of the <see cref="ConceptualCodeConfiguration"/> class.
        /// </overloads>
        /// <summary>
        /// Initializes a new instance of the <see cref="ConceptualCodeConfiguration"/> class
        /// to the default values.
        /// </summary>
        public ConceptualCodeConfiguration()
        {
            _tabSize          = 4;
            _showLineNumbers  = false;
            _showOutlining    = false;
            _highlightEnabled = true;
            _highlightMode    = "IndirectIris";
            _snippetSeparator = "...";
            _snippetStorage   = BuildCacheStorageType.Database;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConceptualCodeConfiguration"/> class
        /// with parameters copied from the specified instance of the 
        /// <see cref="ConceptualCodeConfiguration"/> class, a copy constructor.
        /// </summary>
        /// <param name="source">
        /// An instance of the <see cref="ConceptualCodeConfiguration"/> class from which the
        /// initialization parameters or values will be copied.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If the parameter <paramref name="source"/> is <see langword="null"/>.
        /// </exception>
        public ConceptualCodeConfiguration(
            ConceptualCodeConfiguration source)
            : base(source)
        {
            _tabSize          = source._tabSize;
            _showLineNumbers  = source._showLineNumbers;
            _showOutlining    = source._showOutlining;
            _highlightMode    = source._highlightMode;
            _highlightEnabled = source._highlightEnabled;
            _snippetStorage   = source._snippetStorage;
            _snippetSeparator = source._snippetSeparator;
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the name of the category of options.
        /// </summary>
        /// <value>
        /// <para>
        /// A <see cref="System.String"/> specifying the name of this category of options.
        /// </para>
        /// <para>
        /// The value is <see cref="ConceptualCodeConfiguration.ConfigurationName"/>
        /// </para>
        /// </value>
        public override string Name
        {
            get
            {
                return ConceptualCodeConfiguration.ConfigurationName;
            }
        }

        /// <summary>
        /// Gets a value specifying whether this options category is active, and should
        /// be process.
        /// </summary>
        /// <value>
        /// This is <see langword="true"/> if this options category enabled and userable 
        /// in the build process; otherwise, it is <see langword="false"/>.
        /// </value>
        public override bool IsActive
        {
            get
            {
                return base.IsActive;
            }
        }

        /// <summary>
        /// Gets the source of the build component supported by this configuration.
        /// </summary>
        /// <value>
        /// An enumeration of the type, <see cref="BuildComponentType"/>,
        /// specifying the source of this build component.
        /// </value>
        public override BuildComponentType ComponentType
        {
            get
            {
                return BuildComponentType.SandcastleAssist;
            }
        }

        /// <summary>
        /// Gets the unique name of the build component supported by this configuration. 
        /// </summary>
        /// <value>
        /// A string containing the unique name of the build component, this 
        /// should normally include the namespace.
        /// </value>
        public override string ComponentName
        {
            get
            {
                return "Sandcastle.Components.ConceptualCodeComponent";
            }
        }

        /// <summary>
        /// Gets the path of the build component supported by this configuration.
        /// </summary>
        /// <value>
        /// A string containing the path to the assembly in which the build
        /// component is defined.
        /// </value>
        public override string ComponentPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets a value specifying whether this configuration is displayed or 
        /// visible to the user.
        /// </summary>
        /// <value>
        /// This is <see langword="true"/> if this configuration is visible
        /// and accessible to the user; otherwise it is <see langword="false"/>.
        /// </value>
        public override bool IsBrowsable
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets a copyright and license notification for the component targeted 
        /// by this configuration.
        /// </summary>
        /// <value>
        /// A string specifying the copyright and license of the component.
        /// </value>
        public override string Copyright
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the description of the component targeted by this configuration.
        /// </summary>
        /// <value>
        /// A string providing a description of the component.
        /// </value>
        /// <remarks>
        /// This must be a plain text, brief and informative.
        /// </remarks>
        public override string Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the file name of the documentation explaining the features and
        /// how to use the component.
        /// </summary>
        /// <value>
        /// A string containing the file name of the documentation.
        /// </value>
        /// <remarks>
        /// <para>
        /// This should be either a file name (with file extension, but without
        /// the path) or include a path relative to the assembly containing this
        /// object implementation.
        /// </para>
        /// <para>
        /// The expected file format is HTML, PDF, XPS, CHM and plain text.
        /// </para>
        /// </remarks>
        public override string HelpFileName
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the version of the target component.
        /// </summary>
        /// <value>
        /// An instance of <see cref="System.Version"/> specifying the version
        /// of the target component.
        /// </value>
        public override Version Version
        {
            get
            {
                return new Version(1, 0, 0, 0);
            }
        }

        public int TabSize
        {
            get
            {
                return _tabSize;
            }
            set
            {
                if (value > 0)
                {
                    _tabSize = value;
                }
            }
        }

        public bool HighlightEnabled
        {
            get
            {
                return _highlightEnabled;
            }
            set
            {
                _highlightEnabled = value;
            }
        }

        public bool ShowLineNumbers
        {
            get
            {
                return _showLineNumbers;
            }
            set
            {
                _showLineNumbers = value;
            }
        }

        public string SnippetSeparator
        {
            get
            {
                return _snippetSeparator;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                }

                if (!String.IsNullOrEmpty(value))
                {
                    _snippetSeparator = value;
                }
            }
        }

        public BuildCacheStorageType SnippetStorage
        {
            get
            {
                return _snippetStorage;
            }
            set
            {
                _snippetStorage = value;
            }
        }

        #endregion

        #region Public Methods

        public override void Initialize(BuildContext context)
        {
            base.Initialize(context);

            if (this.IsInitialized)
            {
                _context  = context;
                _settings = context.Settings;
            }
        }

        public override void Uninitialize()
        {
            _context  = null;
            _settings = null;

            base.Uninitialize();
        }

        /// <summary>
        /// The creates the configuration information or settings required by the
        /// target component for the build process.
        /// </summary>
        /// <param name="group">
        /// A build group, <see cref="BuildGroup"/>, representing the documentation
        /// target for configuration.
        /// </param>
        /// <param name="writer">
        /// An <see cref="XmlWriter"/> object used to create one or more new 
        /// child nodes at the end of the list of child nodes of the current node. 
        /// </param>
        /// <returns>
        /// Returns <see langword="true"/> for a successful configuration;
        /// otherwise, it returns <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// The <see cref="XmlWriter"/> writer passed to this configuration object
        /// is created as a new child specifically for this object, and will not
        /// be passed onto other configuration objects.
        /// </remarks>
        public override bool Configure(BuildGroup group, XmlWriter writer)
        {
            BuildExceptions.NotNull(group, "group");
            BuildExceptions.NotNull(writer, "writer");

            if (!this.Enabled || !this.IsInitialized)
            {
                return false;
            }

            Debug.Assert(_settings != null, "The settings object is required.");
            if (_settings == null || _context == null)
            {
                return false;
            }
            BuildStyle buildStyle = _settings.Style;
            Debug.Assert(buildStyle != null, "The style object cannot be null (or Nothing).");
            if (buildStyle == null)
            {
                return false;
            }

            //<component type="Sandcastle.Components.ConceptualCodeComponent" assembly="$(SandAssistComponent)">
            //    <options mode="IndirectIris" tabSize="4" lineNumbers="true" outlining="false" storage="Sqlite" separator="..."/>
            //
            //    <!--The following options are for processing codeReference tags in the 
            //    reference help.
            //    It is a replacement of the ExampleComponent, providing better coloring,
            //    minimum memory usage etc.
            //  
            //    $codeSnippets   
            //      @storage: * Indicates where the code snippets should be stored after loading
            //                * Possible values are
            //                     - Memory: the snippets are stored in memory similar to 
            //                               the ExampleComponent.
            //                     - Database: the snippets are stored in Sqlite database.
            //                * Default: Database 
            //      @separator: * For multi-parts snippets, this defines the separator... 
            //                  * Default: ...-->
            //
            //    <!--<codeSnippets>
            //        <codeSnippet source=".\CodeSnippetSample.xml" format="Sandcastle" />
            //    </codeSnippets>-->
            //    <SandcastleItem name="%CodeSnippets%" />
            //</component>

            writer.WriteStartElement("options");  //start: options
            writer.WriteAttributeString("mode",        _highlightMode);
            writer.WriteAttributeString("tabSize",     _tabSize.ToString());
            writer.WriteAttributeString("lineNumbers", _showLineNumbers.ToString());
            writer.WriteAttributeString("outlining",   _showOutlining.ToString());
            writer.WriteAttributeString("storage",     _snippetStorage.ToString());
            writer.WriteAttributeString("separator",   _snippetSeparator);
            writer.WriteEndElement();             //end: options

            IList<CodeSnippetContent> listSnippets = group.SnippetContents;
            if (listSnippets != null && listSnippets.Count != 0)
            {
                writer.WriteStartElement("codeSnippets");  // start - codeSnippets

                int contentCount = listSnippets.Count;
                for (int i = 0; i < contentCount; i++)
                {
                    CodeSnippetContent snippetContent = listSnippets[i];
                    if (snippetContent == null || snippetContent.IsEmpty)
                    {
                        continue;
                    }
                    writer.WriteStartElement("codeSnippet"); // start - codeSnippet
                    writer.WriteAttributeString("source", snippetContent.ContentFile);
                    writer.WriteAttributeString("format", "Sandcastle");
                    writer.WriteEndElement();                // end - codeSnippet
                }

                writer.WriteEndElement();                  // end - codeSnippets
            }

            SnippetContent snippets = buildStyle.Snippets;
            if (snippets != null && snippets.Count != 0)
            {
                writer.WriteStartElement("codeSources");  // start - codeSources

                for (int i = 0; i < snippets.Count; i++)
                {
                    SnippetItem snippetItem = snippets[i];
                    if (snippetItem == null || snippetItem.IsEmpty)
                    {
                        continue;
                    }
                    writer.WriteStartElement("codeSource"); // start - codeSource
                    writer.WriteAttributeString("source", snippetItem.Source);
                    writer.WriteAttributeString("format", "Sandcastle");
                    writer.WriteEndElement();                // end - codeSource
                }

                // The excludedUnits is required by the SnippetComponent, 
                // we maintain that...
                writer.WriteStartElement("excludedUnits"); // start - excludedUnits
                IList<string> excludedUnits = snippets.ExcludedUnitFolders;
                if (excludedUnits != null && excludedUnits.Count != 0)
                {
                    for (int i = 0; i < excludedUnits.Count; i++)
                    {
                        string unitFolder = excludedUnits[i];
                        if (String.IsNullOrEmpty(unitFolder))
                        {
                            continue;
                        }
                        writer.WriteStartElement("unitFolder"); // start - unitFolder
                        writer.WriteAttributeString("name", unitFolder);
                        writer.WriteEndElement();               // end - unitFolder
                    }
                }
                writer.WriteEndElement();                  // end - excludedUnits 

                writer.WriteStartElement("languages"); // start - languages
                IList<SnippetLanguage> languages = snippets.Languages;
                if (languages != null && languages.Count != 0)
                {
                    for (int i = 0; i < languages.Count; i++)
                    {
                        SnippetLanguage language = languages[i];
                        if (!language.IsValid)
                        {
                            continue;
                        }
                        writer.WriteStartElement("language"); // start - language
                        writer.WriteAttributeString("unit", language.Unit);
                        writer.WriteAttributeString("languageId", language.LanguageId);
                        writer.WriteAttributeString("extension", language.Extension);
                        writer.WriteEndElement();               // end - language
                    }
                }
                writer.WriteEndElement();              // end - languages  

                writer.WriteEndElement();                  // end - codeSources
            }

            return true;
        }

        #endregion

        #region IXmlSerializable Members

        /// <summary>
        /// This reads and sets its state or attributes stored in a <c>XML</c> format
        /// with the given reader. 
        /// </summary>
        /// <param name="reader">
        /// The reader with which the <c>XML</c> attributes of this object are accessed.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If the <paramref name="reader"/> is <see langword="null"/>.
        /// </exception>
        public override void ReadXml(XmlReader reader)
        {
            BuildExceptions.NotNull(reader, "reader");

            Debug.Assert(reader.NodeType == XmlNodeType.Element);
            if (reader.NodeType != XmlNodeType.Element)
            {
                return;
            }

            if (!String.Equals(reader.Name, TagName,
                StringComparison.OrdinalIgnoreCase))
            {
                Debug.Assert(false, String.Format(
                    "The element name '{0}' does not match the expected '{1}'.",
                    reader.Name, TagName));
                return;
            }

            string tempText = reader.GetAttribute("name");
            if (String.IsNullOrEmpty(tempText) || !String.Equals(tempText,
                ConfigurationName, StringComparison.OrdinalIgnoreCase))
            {
                throw new BuildException(String.Format(
                    "ReadXml: The current name '{0}' does not match the expected name '{1}'.",
                    tempText, ConfigurationName));
            }

            if (reader.IsEmptyElement)
            {
                return;
            }

            while (reader.Read())
            {
                if ((reader.NodeType == XmlNodeType.Element) &&
                    String.Equals(reader.Name, "property", 
                    StringComparison.OrdinalIgnoreCase))
                {
                    switch (reader.GetAttribute("name").ToLower())
                    {
                        case "enabled":
                            tempText = reader.ReadString();
                            if (!String.IsNullOrEmpty(tempText))
                            {
                                this.Enabled = Convert.ToBoolean(tempText);
                            }
                            break;
                        case "tabsize":
                            tempText = reader.ReadString();
                            if (!String.IsNullOrEmpty(tempText))
                            {
                                _tabSize = Convert.ToInt32(tempText);
                            }
                            break;
                        case "showlinenumbers":
                            tempText = reader.ReadString();
                            if (!String.IsNullOrEmpty(tempText))
                            {
                                _showLineNumbers = Convert.ToBoolean(tempText);
                            }
                            break;
                        case "showoutlining":
                            tempText = reader.ReadString();
                            if (!String.IsNullOrEmpty(tempText))
                            {
                                _showOutlining = Convert.ToBoolean(tempText);
                            }
                            break;
                        case "highlightenabled":
                            tempText = reader.ReadString();
                            if (!String.IsNullOrEmpty(tempText))
                            {
                                _highlightEnabled = Convert.ToBoolean(tempText);
                            }
                            break;
                        case "highlightmode":
                            _highlightMode = reader.ReadString();
                            break;
                        case "snippetseparator":
                            _snippetSeparator = reader.ReadString();
                            break;
                        case "snippetstorage":
                            tempText = reader.ReadString();
                            if (!String.IsNullOrEmpty(tempText))
                            {
                                _snippetStorage = BuildCacheStorageType.Parse(tempText);
                            }
                            break;
                        default:
                            // Should normally not reach here...
                            throw new NotImplementedException(reader.GetAttribute("name"));
                    }
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (String.Equals(reader.Name, TagName, 
                        StringComparison.OrdinalIgnoreCase))
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// This writes the current state or attributes of this object,
        /// in the <c>XML</c> format, to the media or storage accessible by the given writer.
        /// </summary>
        /// <param name="writer">
        /// The <c>XML</c> writer with which the <c>XML</c> format of this object's state 
        /// is written.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// If the <paramref name="reader"/> is <see langword="null"/>.
        /// </exception>
        public override void WriteXml(XmlWriter writer)
        {
            BuildExceptions.NotNull(writer, "writer");

            writer.WriteStartElement(TagName);  // start - TagName
            writer.WriteAttributeString("name", ConfigurationName);

            // Write the general properties
            writer.WriteStartElement("propertyGroup"); // start - propertyGroup;
            writer.WriteAttributeString("name", "General");
            writer.WritePropertyElement("Enabled",          this.Enabled);
            writer.WritePropertyElement("TabSize",          _tabSize);
            writer.WritePropertyElement("ShowLineNumbers",  _showLineNumbers);
            writer.WritePropertyElement("ShowOutlining",    _showOutlining);
            writer.WritePropertyElement("HighlightEnabled", _highlightEnabled);
            writer.WritePropertyElement("HighlightMode",    _highlightMode);
            writer.WritePropertyElement("SnippetSeparator", _snippetSeparator);
            writer.WritePropertyElement("SnippetStorage",   _snippetStorage.ToString());
            writer.WriteEndElement();                  // end - propertyGroup

            writer.WriteEndElement();           // end - TagName
        }

        #endregion

        #region ICloneable Members

        /// <summary>
        /// This creates a new build object that is a deep copy of the current 
        /// instance.
        /// </summary>
        /// <returns>
        /// A new build object that is a deep copy of this instance.
        /// </returns>
        public override BuildComponentConfiguration Clone()
        {
            ConceptualCodeConfiguration options = new ConceptualCodeConfiguration(this);
            if (_highlightMode != null)
            {
                options._highlightMode = String.Copy(_highlightMode);
            }
            if (_snippetSeparator != null)
            {
                options._snippetSeparator = String.Copy(_snippetSeparator);
            }

            return options;
        }

        #endregion
    }
}
