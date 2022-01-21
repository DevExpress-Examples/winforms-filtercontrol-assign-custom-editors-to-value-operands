<!-- default badges list -->
<<<<<<< HEAD
=======
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128622003/13.1.4%2B)
>>>>>>> 13.1.4+
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1519)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomEditor/Form1.cs) (VB: [Form1.vb](./VB/CustomEditor/Form1.vb))
* [Program.cs](./CS/CustomEditor/Program.cs) (VB: [Program.vb](./VB/CustomEditor/Program.vb))
<!-- default file list end -->
# How to provide custom editors to edit value operands in the FilterControl


<p>In this example, custom editors are provided to edit value operands in the FilterControl. <br />
The custom editors (SpinEdit and CalcEdit) are supplied by handling the BeforeShowValueEditor event. To supply the editors, corresponding repository items are created and assigned to the event's CustomRepositoryItem parameter.</p><p>In the example, the FilterControl is used within a GridControl. To get access and subscribe to the FilterControl's BeforeShowValueEditor event, the GridView.FilterEditorCreated event is handled.</p>

<br/>


