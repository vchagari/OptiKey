﻿using System.Windows;

namespace JuliusSweetland.OptiKey.Services
{
    public interface IMouseService
    {
        void LeftButtonDown();
        void LeftButtonUp();
        void LeftButtonClick();
        void LeftButtonDoubleClick();
        void MiddleButtonClick();
        void MoveTo(Point point);
        void RightButtonClick();
        void ScrollWheelUp(int clicks);
        void ScrollWheelDown(int clicks);
        void ScrollWheelLeft(int clicks);
        void ScrollWheelRight(int clicks);
    }
}
