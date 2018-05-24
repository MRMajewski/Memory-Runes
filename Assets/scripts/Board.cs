using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {


    public Sprite[] sprites;

    Tile[] Tiles;

    public GameObject TilePrefab;

    public int Width = 6;
    public int Height = 4;


	// Use this for initialization
	void Start () {

        CreateTiles();
        PlaceTiles();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateTiles()
    {
        var length = Width * Height;

        Tiles = new Tile[length];

        for (int i=0;i<length;i++)
        {
            Tiles[i] = CreateTile();
        }

    }


    Tile CreateTile()
    {
        var gameObject = Instantiate(TilePrefab);
       

        var tile = gameObject.GetComponent<Tile>();
        tile.frontFace = GetRandomSprite();

        return tile;
    }

    void PlaceTiles()
    {
        for (int i=0;i<Width*Height;i++)
        {
            int x = i % Width;
            int y = i / Width;


            Tiles[i].transform.position += Vector3.up * y+ Vector3.right * x;
        }
    }



    Sprite GetRandomSprite()
    {
        int lenght = sprites.Length;
        int index = Random.Range(0, lenght - 1);
        return sprites[index];
    }

}
