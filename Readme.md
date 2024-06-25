
# Assign custom editors to value operands in the FilterControl


This example handles the [FilterControl.CustomValueEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.FilterControl.CustomValueEditor) event to assign custom editors (Spin Editor and Calc Editor) to value operands in Data Grid's embedded FilterControl. 

The Data Grid's [ColumnView.FilterEditorCreated](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FilterEditorCreated) event is used to subscribe to the [FilterControl.CustomValueEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.FilterControl.CustomValueEditor) event.

## Files to Look At

- [Form1.cs](./CS/CustomEditor/Form1.cs) (VB: [Form1.vb](./VB/CustomEditor/Form1.vb))

## Documentation

- [FilterControl.CustomValueEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.FilterControl.CustomValueEditor)
- [ColumnView.FilterEditorCreated](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.FilterEditorCreated)
