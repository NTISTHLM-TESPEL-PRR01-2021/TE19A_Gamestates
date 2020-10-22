using System;
using Raylib_cs;

namespace Gamestates
{
  class Program
  {
    static void Main(string[] args)
    {

      Raylib.InitWindow(800, 600, "Gamestate testing");

      string scene = "intro";

      float x = 30;
      float y = 30;

      while (!Raylib.WindowShouldClose())
      {





        Raylib.BeginDrawing();

        if (scene == "intro")
        {
          Raylib.ClearBackground(Color.DARKGREEN);
          Raylib.DrawText("INTRO!!!!!", 100, 50, 20, Color.WHITE);

          x = 30;
          y = 30;

          if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
          {
            scene = "game";
          }

        }
        else if (scene == "game")
        {
          Raylib.ClearBackground(Color.DARKBLUE);
          Raylib.DrawText("Game screen", 100, 50, 20, Color.WHITE);


          if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
          {
            y += 0.1f;
          }


          if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
          {
            scene = "intro";
          }

          if (y > Raylib.GetScreenHeight())
          {
            scene = "gameover";
          }

          Raylib.DrawCircle((int)x, (int)y, 10, Color.GOLD);


        }
        else if (scene == "gameover")
        {
          Raylib.ClearBackground(Color.BLACK);
          Raylib.DrawText("GAME OVER MAN, GAME OVER", 100, 50, 20, Color.WHITE);


          if (Raylib.IsKeyPressed(KeyboardKey.KEY_TAB))
          {
            scene = "intro";
          }
        }



        Raylib.EndDrawing();

      }


    }
  }
}
