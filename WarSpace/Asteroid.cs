using System;
using System.Numerics;
using Raylib_cs;
public class Asteroid : Object
{
    public Asteroid()
    {
        this.position = new Vector2(generator.Next(-100, 1400), generator.Next(-100, 1100));
        while (position.X >= -10 && position.X <= 1300 && position.Y >= -10 && position.Y <= 1000)
        {
            this.position = new Vector2(generator.Next(-100, 1400), generator.Next(-100, 1100));
        }
        this.radius = generator.Next(10, 20);
        this.color = Color.RED;
    }

    public void AstreroidRun()
    {
        rotation.X = (float)Math.Cos(angle);
        rotation.Y = (float)Math.Sin(angle);
        position.X += speed.X;
        position.Y += speed.Y;
        hitBox.x = position.X;
        hitBox.y = position.Y;
    }

    public void DrawAsteroid()
    {
        Raylib.DrawCircleV(position, radius, color);
    }
}