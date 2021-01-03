using System;
using System.Threading;

namespace MinecraftCommander.MinecraftWindowControllerPackage
{
    public class MinecraftWindowController
    {
        private Int32 ScreenWidth;
        private Int32 ScreenHeight;
        private Boolean IsCrouching;
        private Random RandomInstance;

        public MinecraftWindowController()
        {
            // TODO get screen height and width

            this.RandomInstance = new Random();
        }

        public void MoveForward(Int32 milliseconds)
        {
            throw new NotImplementedException();
        }

        public void MoveBackward(Int32 milliseconds)
        {
            throw new NotImplementedException();
        }

        public void StrafeRight(Int32 milliseconds)
        {
            throw new NotImplementedException();
        }

        public void StrafeLeft()
        {
            throw new NotImplementedException();
        }

        public void LookAt(double angle, double distance)
        {
            throw new NotImplementedException();
        }

        // Forces camera to be parallel with the ground
        public void LookCenter()
        {
            this.LookAt(270, 10000);

            this.LookAt(0, this.ScreenHeight / 2.0);
        }

        public void Jump()
        {
            throw new NotImplementedException();
        }

        public void StartCrouching()
        {
            if (this.IsCrouching)
            {
                throw new Exception("Already crouching");
            }

            throw new NotImplementedException();
        }

        public void StopCrouching()
        {
            if (!this.IsCrouching)
            {
                throw new Exception("Cannot stop crouching without starting crouching");
            }

            throw new NotImplementedException();
        }

        public void Attack()
        {
            // left-click

            throw new NotImplementedException();
        }

        public void StartUsing()
        {
            // hold right-click

            throw new NotImplementedException();
        }

        public void StopUsing()
        {
            // release right-click

            throw new NotImplementedException();
        }

        public void TriggerRunning()
        {
            // tap left Ctrl

            throw new NotImplementedException();
        }

        public void Spin(double degrees)
        {
            double distance = Math.Abs(degrees / Math.Tau * this.ScreenWidth);
            if (degrees < 0)
            {
                this.LookAt(270, distance);
            }
            else
            {
                this.LookAt(90, distance);
            }
        }

        public Boolean TryReleaseSemaphore(SemaphoreSlim semaphore)
        {
            if (this.RandomInstance.Next(2) == 0)
            {
                semaphore.Release();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ShuffleForward(Int32 pixels)
        {
            // set character down
            // _attempt_total = 1
            // while not _was_character_released:
            //   _was_character_released = try_set_character_up()
            //   _attempt_total += 1
            //   time.sleep(_time_per_attempt)
            // _seconds_total = _time_per_attempt * _attempt_total
            // 
        }
    }
}
