using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Controls.HtmlControls.HtmlAsserts;
using ArtOfTest.WebAii.Design;
using ArtOfTest.WebAii.Design.Execution;
using ArtOfTest.WebAii.ObjectModel;
using ArtOfTest.WebAii.Silverlight;
using ArtOfTest.WebAii.Silverlight.UI;
using Telerik.WebAii.Controls.Html;
using Telerik.WebAii.Controls.Xaml;

namespace KendoDemosTests
{

    //
    // You can add custom execution steps by simply
    // adding a void function and decorating it with the [CodedStep] 
    // attribute to the test method. 
    // Those steps will automatically show up in the test steps on save.
    //
    // The BaseWebAiiTest exposes all key objects that you can use
    // to access the current testcase context. [i.e. ActiveBrowser, Find ..etc]
    //
    // Data driven tests can use the Data[columnIndex] or Data["columnName"] 
    // to access data for a specific data iteration.
    //
    // Example:
    //
    // [CodedStep("MyCustom Step Description")]
    // public void MyCustomStep()
    // {
    //        // Custom code goes here
    //      ActiveBrowser.NavigateTo("http://www.google.com");
    //
    //        // Or
    //        ActiveBrowser.NavigateTo(Data["url"]);
    // }
    //
        

    public class FindStartingWith : BaseWebAiiTest
    {
        #region [ Dynamic Pages Reference ]

        private Pages _pages;

        /// <summary>
        /// Gets the Pages object that has references
        /// to all the elements, frames or regions
        /// in this project.
        /// </summary>
        public Pages Pages
        {
            get
            {
                if (_pages == null)
                {
                    _pages = new Pages(Manager.Current);
                }
                return _pages;
            }
        }

        #endregion

        //[CodedStep(@"Verify element 'ProductsText' 'is' visible.")]
        //public void FindStartingWith_CodedStep()
        //{

        //    // Verify element 'ProductsText' 'is' visible.
        //    HtmlControl ProductsText = Pages.API7.TheShawshankListItem;
        //    ProductsText.Wait.ForExists(10000);
        //    Assert.IsTrue(ProductsText.IsVisible());

        //}

        [CodedStep(@"@\Verify element 'ProductsText' 'is' visible.")]
        public void FindStartingWith_CodedStep1()
        {


            // Verify element 'ProductsText' 'is' visible.
            HtmlControl ProductsText = Pages.API7.TheShawshankListItem;
            ProductsText.Wait.ForExists(10000);
            Assert.IsTrue(ProductsText.IsVisible());



        }
        
        // Add your test methods here...
    }
}
