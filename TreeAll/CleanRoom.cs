using System;
using System.Collections.Generic;
using System.Text;

namespace TreeAll
{
   public class CleanRoom
    {


        //private int direction = 1;  //1:up, 2:right, 3:down, 4:left
        //private HashSet<Tuple<int, int>> cleaned = new HashSet<Tuple<int, int>>();
        //private Tuple<int, int> current = new Tuple<int, int>(0, 0);
        //public void CleanRoom1(Robot robot)
        //{

        //    robot.Clean();
        //    cleaned.Add(current);

        //    Tuple<int, int> next;
        //    Tuple<int, int> orig = new Tuple<int, int>(current.Item1, current.Item2);

        //    //try to go up
        //    next = new Tuple<int, int>(current.Item1 - 1, current.Item2);
        //    if (!cleaned.Contains(next))
        //    {
        //        TurnTo(1, robot);
        //        if (robot.Move())
        //        {
        //            current = next;
        //            CleanRoom1(robot);
        //            TurnTo(3, robot);
        //            robot.Move();
        //            current = orig;
        //        }
        //    }

        //    //try to go right
        //    next = new Tuple<int, int>(current.Item1, current.Item2 + 1);
        //    if (!cleaned.Contains(next))
        //    {
        //        TurnTo(2, robot);
        //        if (robot.Move())
        //        {
        //            current = next;
        //            CleanRoom1(robot);
        //            TurnTo(4, robot);
        //            robot.Move();
        //            current = orig;
        //        }
        //    }

        //    //try to go down
        //    next = new Tuple<int, int>(current.Item1 + 1, current.Item2);
        //    if (!cleaned.Contains(next))
        //    {
        //        TurnTo(3, robot);
        //        if (robot.Move())
        //        {
        //            current = next;
        //            CleanRoom1(robot);
        //            TurnTo(1, robot);
        //            robot.Move();
        //            current = orig;
        //        }
        //    }

        //    //try to go left
        //    next = new Tuple<int, int>(current.Item1, current.Item2 - 1);
        //    if (!cleaned.Contains(next))
        //    {
        //        TurnTo(4, robot);
        //        if (robot.Move())
        //        {
        //            current = next;
        //            CleanRoom1(robot);
        //            TurnTo(2, robot);
        //            robot.Move();
        //            current = orig;
        //        }
        //    }
        //}

        //public void TurnTo(int desiredDirection, Robot robot)
        //{
        //    int delta = desiredDirection - direction;
        //    if (delta == 0)
        //        return;
        //    if (delta == 1 || delta == -3)
        //        robot.TurnRight();
        //    else if (delta == -1 || delta == 3)
        //        robot.TurnLeft();
        //    else
        //    {
        //        robot.TurnLeft();
        //        robot.TurnLeft();
        //    }
        //    direction = desiredDirection;
        //}
    }

   public interface Robot
    {
        // returns true if next cell is open and robot moves into the cell.
        // returns false if next cell is obstacle and robot stays on the current cell.
        bool move();

        // Robot will stay on the same cell after calling turnLeft/turnRight.
        // Each turn will be 90 degrees.
        void turnLeft();
        void turnRight();

        // Clean the current cell.
        void clean();
    }
}

