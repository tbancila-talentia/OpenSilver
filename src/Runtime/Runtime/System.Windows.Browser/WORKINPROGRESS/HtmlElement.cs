﻿

/*===================================================================================
* 
*   Copyright (c) Userware/OpenSilver.net
*      
*   This file is part of the OpenSilver Runtime (https://opensilver.net), which is
*   licensed under the MIT license: https://opensource.org/licenses/MIT
*   
*   As stated in the MIT license, "the above copyright notice and this permission
*   notice shall be included in all copies or substantial portions of the Software."
*  
\*====================================================================================*/


using System;
using System.Security;

namespace System.Windows.Browser
{
    #if WORKINPROGRESS
    public sealed partial class HtmlElement : HtmlObject
    {
        #region Fields
        private ScriptObjectCollection _children;
        #endregion

        #region Properties
        public ScriptObjectCollection Children
        {
            get { return _children; }
        }
        public string Id { get; set; }

        //
        // Summary:
        //     Gets or sets the cascading style sheet (CSS) class string for the current
        //     HTML element.
        //
        // Returns:
        //     A CSS class string if the element is associated with a CSS class; otherwise,
        //     an empty string.
        public string CssClass { get; set; }
        #endregion

        #region Methods
        // Summary:
        //     Sets the browser focus to the current HTML element.
        //
        // Exceptions:
        //   System.InvalidOperationException:
        //     All errors.
        [SecuritySafeCritical]
        public void Focus()
        {

        }

        internal HtmlElement()
        {
            _children = null;
        }
        public void AppendChild(HtmlElement @element)
        {
        }
        public void AppendChild(HtmlElement @element, HtmlElement @referenceElement)
        {
        }
        public void RemoveChild(HtmlElement @element)
        {
        }
        public void SetAttribute(string @name, string @value)
        {
        }
        public string GetStyleAttribute(string @name)
        {
            return default(string);
        }
        public void SetStyleAttribute(string @name, string @value)
        {
        }
        public void RemoveStyleAttribute(string name)
        {

        }
        //
        // Summary:
        //     Removes an attribute from the current HTML element.
        //
        // Parameters:
        //   name:
        //     The name of the attribute to remove.
        //
        // Exceptions:
        //   System.ArgumentException:
        //     name is an empty string.
        //
        //   System.ArgumentNullException:
        //     name is null.
        public void RemoveAttribute(string name)
        {

        }
        #endregion
    }
#endif
}
