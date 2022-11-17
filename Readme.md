<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1233)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/Q144847/Form1.cs) (VB: [Form1.vb](./VB/Q144847/Form1.vb))**
* [Northwind.cs](./CS/Q144847/Northwind.cs) (VB: [Northwind.vb](./VB/Q144847/Northwind.vb))
<!-- default file list end -->
# How to use the XPPageSelector with the GridControl


<p><strong>Scenario</strong><br />This article illustrates how to use the <a href="https://documentation.devexpress.com/#XPO/clsDevExpressXpoXPPageSelectortopic">XPPageSelector</a> component to provide Pager functionally to the XtraGrid control. This functionality is useful when you need to show data in small portions.<br /><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-the-xppageselector-with-the-gridcontrol-e1233/13.1.4+/media/f78f5c32-18ae-11e4-80b8-00155d624807.png"><br /><strong>Steps<br />1. </strong>Create a new Windows Forms Application.<br /><strong>2. </strong>Add <strong>DXperience ORM Data Model Wizard </strong>to the application and use the <a href="https://documentation.devexpress.com/#XPO/CustomDocument3334">Generating Persistent Objects for Existing Data Tables</a>  approach to generate persistent objects from an existing database.<br /><strong>3. </strong>Add the <a href="https://documentation.devexpress.com/#XPO/clsDevExpressXpoXPCollectiontopic">XPCollection</a> component to a Form and set the <a href="https://documentation.devexpress.com/#XPO/DevExpressXpoXPCollection_ObjectClassInfotopic">ObjectClassInfo</a> property to the generated persistent object type to populate this collection with required objects. <br /><strong>4. </strong>Add the <a href="https://documentation.devexpress.com/#XPO/clsDevExpressXpoXPPageSelectortopic">XPPageSelector</a> component to the Form and set the Collection property to XPCollection.<br /><strong>5</strong>. Add <a href="https://documentation.devexpress.com/#windowsforms/clsDevExpressXtraGridGridControltopic">GridControl</a>  to the Form and use the XPPageSelector as a data source.<br /><strong>6</strong>. Add two Buttons and a Label. These controls will be responsible for page navigation. <br /><strong>7. </strong>Handle <a href="http://msdn.microsoft.com/en-us/library/system.web.ui.webcontrols.button.click(v=vs.110).aspx">Button.Click</a> events and create a method, which will update Label text as shown in the <em>Form1.xx </em>file.<br /><br /></p>
<p><strong>Important notes:</strong><br />Please note that paging is not applicable to the XtraGrid, as the grid requires the entire collection to correctly apply any sorting, grouping or filtering. Therefore, grouping, sorting and filtering will only be applied to the current page when the grid is bound to the XPPageSelector component. We suggest that you use the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument8398">Server Mode</a>  feature instead.<br /><br /><strong>See also:</strong><br /><a href="https://docs.devexpress.com/XPO/2263/getting-started#using-xpo-in-desktop-applications">Using XPO in Desktop Applications</a><br /><a href="https://documentation.devexpress.com/XPO/CustomDocument1999.aspx">How to: Bind an XPCollection to the Grid</a>  </p>

<br/>


