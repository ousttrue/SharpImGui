using System;
using System.Numerics;
using SharpImGui;

namespace sample
{
    class OrbitCamera
    {
        public CameraState state = new CameraState
        {
            fovYRadians = 30.0f / 180.0f * MathF.PI
        };

        float zNear = 0.1f;
        float zFar = 100.0f;
        float aspectRatio = 1.0f;

        int prevMouseX = -1;
        int prevMouseY = -1;

        float shiftX = 0;
        float shiftY = 0;
        float shiftZ = 2.0f;
        float yawRadians = 0;
        float pitchRadians = 0;

        public OrbitCamera()
        {
            CalcView();
            CalcPerspective();
            CalcViewProjection();
        }

        void CalcView()
        {
            var yaw = Matrix4x4.CreateRotationY(yawRadians);
            var pitch = Matrix4x4.CreateRotationX(pitchRadians);
            var yawPitch = yaw * pitch;
            var t = Matrix4x4.CreateTranslation(-shiftX, -shiftY, -shiftZ);
            state.view = yawPitch * t;

            t.M12 *= -1;
            t.M13 *= -1;
            t.M14 *= -1;
            state.viewInverse = t * Matrix4x4.Transpose(yawPitch);
        }

        void CalcPerspective()
        {
            state.projection = Matrix4x4.CreatePerspectiveFieldOfView(state.fovYRadians, aspectRatio, zNear, zFar);
        }

        void CalcViewProjection()
        {
            state.viewProjection = state.view * state.projection;
        }

        void SetViewport(int x, int y, int w, int h)
        {
            if (w == state.viewportWidth && h == state.viewportHeight)
            {
                return;
            }
            if (h == 0 || w == 0)
            {
                aspectRatio = 1.0f;
            }
            else
            {
                aspectRatio = w / (float)h;
            }
            // state.viewportX = x;
            // state.viewportY = y;
            state.viewportWidth = w;
            state.viewportHeight = h;
            CalcPerspective();
        }

        public void MouseInput(MouseState mouse, int width, int height)
        {
            SetViewport(0, 0, width, height);

            if (prevMouseX != -1 && prevMouseY != -1)
            {
                var deltaX = mouse.X - prevMouseX;
                var deltaY = mouse.Y - prevMouseY;

                if (mouse.Buttons.HasFlag(ButtonFlags.Right))
                {
                    const float FACTOR = 1.0f / 180.0f * 1.7f;
                    yawRadians += deltaX * FACTOR;
                    pitchRadians += deltaY * FACTOR;
                }
                if (mouse.Buttons.HasFlag(ButtonFlags.Middle))
                {
                    shiftX -= deltaX / (float)state.viewportHeight * shiftZ;
                    shiftY += deltaY / (float)state.viewportHeight * shiftZ;
                }
                if (mouse.Wheel > 0)
                {
                    shiftZ *= 0.9f;
                }
                else if (mouse.Wheel < 0)
                {
                    shiftZ *= 1.1f;
                }
            }
            prevMouseX = mouse.X;
            prevMouseY = mouse.Y;
            CalcView();
            CalcViewProjection();
        }
    }
}
