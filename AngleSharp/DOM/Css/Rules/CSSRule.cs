﻿namespace AngleSharp.DOM.Css
{
    using AngleSharp.DOM.Collections;
    using AngleSharp.Parser.Css;
    using System;

    /// <summary>
    /// Represents a CSS rule.
    /// </summary>
    [DomName("CSSRule")]
    public abstract class CSSRule : ICssObject
    {
        #region Fields

        /// <summary>
        /// The type of CSS rule.
        /// </summary>
        protected CssRuleType _type;
        /// <summary>
        /// The parent stylesheet.
        /// </summary>
        protected CSSStyleSheet _parent;
        /// <summary>
        /// The parent rule.
        /// </summary>
        protected CSSRule _parentRule;

        #endregion

        #region ctor

        /// <summary>
        /// Creates a new CSS rule.
        /// </summary>
        internal CSSRule()
        {
            _type = CssRuleType.Unknown;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the textual representation of the rule.
        /// </summary>
        [DomName("cssText")]
        public String CssText
        {
            get { return ToCss(); }
        }

        /// <summary>
        /// Gets the containing rule, otherwise null.
        /// </summary>
        [DomName("parentRule")]
        public CSSRule ParentRule
        {
            get { return _parentRule; }
            internal set { _parentRule = value; }
        }

        /// <summary>
        /// Gets the CSSStyleSheet object for the style sheet that contains this rule.
        /// </summary>
        [DomName("parentStyleSheet")]
        public CSSStyleSheet ParentStyleSheet
        {
            get { return _parent; }
            internal set { _parent = value; }
        }


        /// <summary>
        /// Gets the type constant indicating the type of CSS rule.
        /// </summary>
        [DomName("type")]
        public CssRuleType Type
        {
            get { return _type; }
        }

        #endregion

        #region Internal Methods

        /// <summary>
        /// Computes the style for the given element within the specified window
        /// context. Writes the properties into the specified style declaration.
        /// </summary>
        /// <param name="style">The declaration that is used.</param>
        /// <param name="window">The given window context.</param>
        /// <param name="element">The element that is computed.</param>
        internal virtual void ComputeStyle(CSSStyleDeclaration style, IWindow window, Element element)
        {
            //By default nothing gets computed.
        }

        #endregion

        #region String representation

        /// <summary>
        /// Returns a CSS code representation of the rule.
        /// </summary>
        /// <returns>A string that contains the code.</returns>
        public abstract String ToCss();

        #endregion
    }
}
