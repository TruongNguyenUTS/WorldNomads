﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 12.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1 - Use 'RecordedMethod1Params' to pass parameters into this method.
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinButton uISearchthewebandWindoButton = this.UISearchthewebandWindoWindow.UISearchthewebandWindoButton;
            BrowserWindow uINewtabInternetExplorWindow = this.UINewtabInternetExplorWindow;
            HtmlEdit uIInputNumberEdit = this.UINewtabInternetExplorWindow.UIHomePageMyASPNETApplDocument.UIInputNumberEdit;
            HtmlInputButton uISubmitButton = this.UINewtabInternetExplorWindow.UIHomePageMyASPNETApplDocument.UISubmitButton;
            #endregion

            // Click 'Search the web and Windows' button
            Mouse.Click(uISearchthewebandWindoButton, new Point(152, 4));

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // To test Windows Store apps, use the Coded UI Test project template for Windows Store apps under the Windows Store node.

            // Go to web page 'http://localhost/test/'
            uINewtabInternetExplorWindow.NavigateToUrl(new System.Uri(this.RecordedMethod1Params.UINewtabInternetExplorWindowUrl));

            // Type '20' in 'Input Number' text box
            uIInputNumberEdit.Text = this.RecordedMethod1Params.UIInputNumberEditText;

            // Type '{Enter}' in 'Input Number' text box
            Keyboard.SendKeys(uIInputNumberEdit, this.RecordedMethod1Params.UIInputNumberEditSendKeys, ModifierKeys.None);

            // Type '20' in 'Input Number' text box
            uIInputNumberEdit.Text = this.RecordedMethod1Params.UIInputNumberEditText1;

            // Click 'Submit' button
            Mouse.Click(uISubmitButton, new Point(32, 27));
        }
        
        /// <summary>
        /// AssertMethod1 - Use 'AssertMethod1ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod1()
        {
            #region Variable Declarations
            HtmlSpan uIAllNumberPane = this.UINewtabInternetExplorWindow.UIHomePageMyASPNETApplDocument.UIAllNumberPane;
            #endregion

            // Verify that the 'DisplayText' property of 'All Number:' pane equals 'All Number: '
            Assert.AreEqual(this.AssertMethod1ExpectedValues.UIAllNumberPaneDisplayText, uIAllNumberPane.DisplayText);
        }
        
        /// <summary>
        /// AssertMethod2 - Use 'AssertMethod2ExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertMethod2()
        {
            #region Variable Declarations
            HtmlSpan uISuccessPane = this.UINewtabInternetExplorWindow.UIHomePageMyASPNETApplDocument.UISuccessPane;
            #endregion

            // Verify that the 'DisplayText' property of 'Success' pane equals 'Success'
            Assert.AreEqual(this.AssertMethod2ExpectedValues.UISuccessPaneDisplayText, uISuccessPane.DisplayText);
        }
        
        #region Properties
        public virtual RecordedMethod1Params RecordedMethod1Params
        {
            get
            {
                if ((this.mRecordedMethod1Params == null))
                {
                    this.mRecordedMethod1Params = new RecordedMethod1Params();
                }
                return this.mRecordedMethod1Params;
            }
        }
        
        public virtual AssertMethod1ExpectedValues AssertMethod1ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod1ExpectedValues == null))
                {
                    this.mAssertMethod1ExpectedValues = new AssertMethod1ExpectedValues();
                }
                return this.mAssertMethod1ExpectedValues;
            }
        }
        
        public virtual AssertMethod2ExpectedValues AssertMethod2ExpectedValues
        {
            get
            {
                if ((this.mAssertMethod2ExpectedValues == null))
                {
                    this.mAssertMethod2ExpectedValues = new AssertMethod2ExpectedValues();
                }
                return this.mAssertMethod2ExpectedValues;
            }
        }
        
        public UISearchthewebandWindoWindow UISearchthewebandWindoWindow
        {
            get
            {
                if ((this.mUISearchthewebandWindoWindow == null))
                {
                    this.mUISearchthewebandWindoWindow = new UISearchthewebandWindoWindow();
                }
                return this.mUISearchthewebandWindoWindow;
            }
        }
        
        public UINewtabInternetExplorWindow UINewtabInternetExplorWindow
        {
            get
            {
                if ((this.mUINewtabInternetExplorWindow == null))
                {
                    this.mUINewtabInternetExplorWindow = new UINewtabInternetExplorWindow();
                }
                return this.mUINewtabInternetExplorWindow;
            }
        }
        #endregion
        
        #region Fields
        private RecordedMethod1Params mRecordedMethod1Params;
        
        private AssertMethod1ExpectedValues mAssertMethod1ExpectedValues;
        
        private AssertMethod2ExpectedValues mAssertMethod2ExpectedValues;
        
        private UISearchthewebandWindoWindow mUISearchthewebandWindoWindow;
        
        private UINewtabInternetExplorWindow mUINewtabInternetExplorWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'RecordedMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class RecordedMethod1Params
    {
        
        #region Fields
        /// <summary>
        /// Go to web page 'http://localhost/test/'
        /// </summary>
        public string UINewtabInternetExplorWindowUrl = "http://localhost/test/";
        
        /// <summary>
        /// Type '20' in 'Input Number' text box
        /// </summary>
        public string UIInputNumberEditText = "20";
        
        /// <summary>
        /// Type '{Enter}' in 'Input Number' text box
        /// </summary>
        public string UIInputNumberEditSendKeys = "{Enter}";
        
        /// <summary>
        /// Type '20' in 'Input Number' text box
        /// </summary>
        public string UIInputNumberEditText1 = "20";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod1'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class AssertMethod1ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'All Number:' pane equals 'All Number: '
        /// </summary>
        public string UIAllNumberPaneDisplayText = "All Number: ";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertMethod2'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class AssertMethod2ExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of 'Success' pane equals 'Success'
        /// </summary>
        public string UISuccessPaneDisplayText = "Success";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UISearchthewebandWindoWindow : WinWindow
    {
        
        public UISearchthewebandWindoWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Search the web and Windows";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("Search the web and Windows");
            #endregion
        }
        
        #region Properties
        public WinButton UISearchthewebandWindoButton
        {
            get
            {
                if ((this.mUISearchthewebandWindoButton == null))
                {
                    this.mUISearchthewebandWindoButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISearchthewebandWindoButton.SearchProperties[WinButton.PropertyNames.Name] = "Search the web and Windows";
                    this.mUISearchthewebandWindoButton.WindowTitles.Add("Search the web and Windows");
                    #endregion
                }
                return this.mUISearchthewebandWindoButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUISearchthewebandWindoButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UINewtabInternetExplorWindow : BrowserWindow
    {
        
        public UINewtabInternetExplorWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "New tab";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("New tab");
            this.WindowTitles.Add("Home Page - My ASP.NET Application");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIHomePageMyASPNETApplDocument UIHomePageMyASPNETApplDocument
        {
            get
            {
                if ((this.mUIHomePageMyASPNETApplDocument == null))
                {
                    this.mUIHomePageMyASPNETApplDocument = new UIHomePageMyASPNETApplDocument(this);
                }
                return this.mUIHomePageMyASPNETApplDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIHomePageMyASPNETApplDocument mUIHomePageMyASPNETApplDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "12.0.31101.0")]
    public class UIHomePageMyASPNETApplDocument : HtmlDocument
    {
        
        public UIHomePageMyASPNETApplDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "Home Page - My ASP.NET Application";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/test/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost/test/";
            this.WindowTitles.Add("Home Page - My ASP.NET Application");
            #endregion
        }
        
        #region Properties
        public HtmlEdit UIInputNumberEdit
        {
            get
            {
                if ((this.mUIInputNumberEdit == null))
                {
                    this.mUIInputNumberEdit = new HtmlEdit(this);
                    #region Search Criteria
                    this.mUIInputNumberEdit.SearchProperties[HtmlEdit.PropertyNames.Id] = "InputNumber";
                    this.mUIInputNumberEdit.SearchProperties[HtmlEdit.PropertyNames.Name] = "InputNumber";
                    this.mUIInputNumberEdit.FilterProperties[HtmlEdit.PropertyNames.LabeledBy] = "Input Number";
                    this.mUIInputNumberEdit.FilterProperties[HtmlEdit.PropertyNames.Type] = "SINGLELINE";
                    this.mUIInputNumberEdit.FilterProperties[HtmlEdit.PropertyNames.Title] = null;
                    this.mUIInputNumberEdit.FilterProperties[HtmlEdit.PropertyNames.Class] = "form-control";
                    this.mUIInputNumberEdit.FilterProperties[HtmlEdit.PropertyNames.ControlDefinition] = "name=\"InputNumber\" class=\"form-control\" ";
                    this.mUIInputNumberEdit.FilterProperties[HtmlEdit.PropertyNames.TagInstance] = "1";
                    this.mUIInputNumberEdit.WindowTitles.Add("Home Page - My ASP.NET Application");
                    #endregion
                }
                return this.mUIInputNumberEdit;
            }
        }
        
        public HtmlInputButton UISubmitButton
        {
            get
            {
                if ((this.mUISubmitButton == null))
                {
                    this.mUISubmitButton = new HtmlInputButton(this);
                    #region Search Criteria
                    this.mUISubmitButton.SearchProperties[HtmlButton.PropertyNames.Id] = null;
                    this.mUISubmitButton.SearchProperties[HtmlButton.PropertyNames.Name] = null;
                    this.mUISubmitButton.SearchProperties[HtmlButton.PropertyNames.DisplayText] = "Submit";
                    this.mUISubmitButton.SearchProperties[HtmlButton.PropertyNames.Type] = "submit";
                    this.mUISubmitButton.FilterProperties[HtmlButton.PropertyNames.Title] = null;
                    this.mUISubmitButton.FilterProperties[HtmlButton.PropertyNames.Class] = "btn btn-default";
                    this.mUISubmitButton.FilterProperties[HtmlButton.PropertyNames.ControlDefinition] = "class=\"btn btn-default\" type=\"submit\" va";
                    this.mUISubmitButton.FilterProperties[HtmlButton.PropertyNames.TagInstance] = "2";
                    this.mUISubmitButton.WindowTitles.Add("Home Page - My ASP.NET Application");
                    #endregion
                }
                return this.mUISubmitButton;
            }
        }
        
        public HtmlSpan UIAllNumberPane
        {
            get
            {
                if ((this.mUIAllNumberPane == null))
                {
                    this.mUIAllNumberPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUIAllNumberPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUIAllNumberPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUIAllNumberPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "All Number: ";
                    this.mUIAllNumberPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUIAllNumberPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUIAllNumberPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"font-style: italic; font-weight: bold;\"";
                    this.mUIAllNumberPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "4";
                    this.mUIAllNumberPane.WindowTitles.Add("Home Page - My ASP.NET Application");
                    #endregion
                }
                return this.mUIAllNumberPane;
            }
        }
        
        public HtmlSpan UISuccessPane
        {
            get
            {
                if ((this.mUISuccessPane == null))
                {
                    this.mUISuccessPane = new HtmlSpan(this);
                    #region Search Criteria
                    this.mUISuccessPane.SearchProperties[HtmlDiv.PropertyNames.Id] = null;
                    this.mUISuccessPane.SearchProperties[HtmlDiv.PropertyNames.Name] = null;
                    this.mUISuccessPane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = "Success";
                    this.mUISuccessPane.FilterProperties[HtmlDiv.PropertyNames.Title] = null;
                    this.mUISuccessPane.FilterProperties[HtmlDiv.PropertyNames.Class] = null;
                    this.mUISuccessPane.FilterProperties[HtmlDiv.PropertyNames.ControlDefinition] = "style=\"font-size: 17px; font-weight: bold;\"";
                    this.mUISuccessPane.FilterProperties[HtmlDiv.PropertyNames.TagInstance] = "4";
                    this.mUISuccessPane.WindowTitles.Add("Home Page - My ASP.NET Application");
                    #endregion
                }
                return this.mUISuccessPane;
            }
        }
        #endregion
        
        #region Fields
        private HtmlEdit mUIInputNumberEdit;
        
        private HtmlInputButton mUISubmitButton;
        
        private HtmlSpan mUIAllNumberPane;
        
        private HtmlSpan mUISuccessPane;
        #endregion
    }
}
