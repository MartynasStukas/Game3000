using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
public class Sprite
{

    public Texture2D Texture { get; set; }
    public int Rows { get; set; }

    public int Columns { get; set; }

    private int currentFrame;

    private int totalFrames;
	public Sprite()
	{
	}

    public Sprite(Texture2D texture, int rows, int columns)
    {
        Texture = texture;
        Rows = rows;
        Columns = columns;
        currentFrame = 0;
        totalFrames = Rows * Columns;
    }

    public void Update()
    {
        currentFrame++;
        if(currentFrame == totalFrames)
        {
            currentFrame = 0;
        }
    }

    public void Draw(SpriteBatch spriteBatch, Vector2 location)
    {

    }
}
