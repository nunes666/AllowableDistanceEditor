using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(AllowableDistance))]
public class AllowableDistanceEditor: Editor
{
	public override void OnInspectorGUI ()
	{
		AllowableDistance myDistance = (AllowableDistance)target;

		myDistance.allowableDistance = EditorGUILayout.FloatField("Allowable Distance", myDistance.allowableDistance);
	}

	public void OnSceneGUI()
	{

		AllowableDistance myDistance = (AllowableDistance)target;

		myDistance.allowableDistance = Handles.RadiusHandle( Quaternion.identity, myDistance.transform.position, myDistance.allowableDistance);

		Handles.color = Color.blue;
		Handles.CircleCap( 0, myDistance.transform.position, myDistance.transform.rotation, myDistance.allowableDistance);

		if (GUI.changed)
			EditorUtility.SetDirty (target);
	}
}
