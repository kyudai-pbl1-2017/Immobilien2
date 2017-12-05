using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class furniture_size : MonoBehaviour {

	public GameObject table_7103;
	public InputField x;
	public InputField y;
	public InputField z;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void size_change()
	{
		float x_ = float.Parse(x.text);
		float y_ = float.Parse(y.text);
		float z_ = float.Parse(z.text);

		float mesh_x = table_7103.GetComponent<MeshFilter> ().mesh.bounds.size.x;
		float mesh_y = table_7103.GetComponent<MeshFilter> ().mesh.bounds.size.y;
		float mesh_z = table_7103.GetComponent<MeshFilter> ().mesh.bounds.size.z;

		table_7103.transform.localScale = new Vector3 (x_/mesh_x, y_/mesh_y, z_/mesh_z);


	}
}
