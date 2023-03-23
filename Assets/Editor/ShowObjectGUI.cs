/// <summary>
/// Author: AkilarLiao
/// Date: 2023/03/24
/// Desc:
/// </summary>
using UnityEngine;
using UnityEditor;

public class ShowObjectGUI
{
	protected Editor _selfEditor = null;
	protected Object _targetObject = null;

	protected void DestorySelfEditor()
	{
		if (_selfEditor)
		{
			GameObject.DestroyImmediate(_selfEditor);
			_selfEditor = null;
		}
	}

	public virtual void UpdateObjectGUI(Object targetObject)
	{   
		if (_targetObject != targetObject)
			DestorySelfEditor();

		if (!targetObject)
			return;

		_targetObject = targetObject;

		if(!_selfEditor)
			_selfEditor = Editor.CreateEditor(targetObject);
		Debug.Assert(_selfEditor);

		OupdateGUI();
	}
	protected virtual void OupdateGUI()
	{
		_selfEditor.DrawHeader();
		EditorGUI.indentLevel++;
		_selfEditor.OnInspectorGUI();
	}
}