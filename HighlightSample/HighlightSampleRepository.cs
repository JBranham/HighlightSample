﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace HighlightSample
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the HighlightSampleRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.2")]
    [RepositoryFolder("c7483afe-5891-438a-980a-2fa13049d6ef")]
    public partial class HighlightSampleRepository : RepoGenBaseFolder
    {
        static HighlightSampleRepository instance = new HighlightSampleRepository();
        HighlightSampleRepositoryFolders.CalculatorAppFolder _calculator;

        /// <summary>
        /// Gets the singleton class instance representing the HighlightSampleRepository element repository.
        /// </summary>
        [RepositoryFolder("c7483afe-5891-438a-980a-2fa13049d6ef")]
        public static HighlightSampleRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public HighlightSampleRepository() 
            : base("HighlightSampleRepository", "/", null, 0, false, "c7483afe-5891-438a-980a-2fa13049d6ef", ".\\RepositoryImages\\HighlightSampleRepositoryc7483afe.rximgres")
        {
            _calculator = new HighlightSampleRepositoryFolders.CalculatorAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c7483afe-5891-438a-980a-2fa13049d6ef")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Calculator folder.
        /// </summary>
        [RepositoryFolder("b2a11d3f-5b5e-4b5c-ada2-0b62b910a0e4")]
        public virtual HighlightSampleRepositoryFolders.CalculatorAppFolder Calculator
        {
            get { return _calculator; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.4.2")]
    public partial class HighlightSampleRepositoryFolders
    {
        /// <summary>
        /// The CalculatorAppFolder folder.
        /// </summary>
        [RepositoryFolder("b2a11d3f-5b5e-4b5c-ada2-0b62b910a0e4")]
        public partial class CalculatorAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _viewInfo;

            /// <summary>
            /// Creates a new Calculator  folder.
            /// </summary>
            public CalculatorAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Calculator", "/form[@title='Calculator']", parentFolder, 30000, null, true, "b2a11d3f-5b5e-4b5c-ada2-0b62b910a0e4", "")
            {
                _viewInfo = new RepoItemInfo(this, "View", "?/?/menuitem[@accessiblename='View']", 30000, null, "ff14cfaa-c286-4537-9eaf-fcd8966657fe");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b2a11d3f-5b5e-4b5c-ada2-0b62b910a0e4")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b2a11d3f-5b5e-4b5c-ada2-0b62b910a0e4")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The View item.
            /// </summary>
            [RepositoryItem("ff14cfaa-c286-4537-9eaf-fcd8966657fe")]
            public virtual Ranorex.MenuItem View
            {
                get
                {
                    return _viewInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The View item info.
            /// </summary>
            [RepositoryItemInfo("ff14cfaa-c286-4537-9eaf-fcd8966657fe")]
            public virtual RepoItemInfo ViewInfo
            {
                get
                {
                    return _viewInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}