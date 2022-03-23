﻿////////////////////////////////////////////////////////////////////////////
//
// FlashCap - Independent camera capture library.
// Copyright (c) Kouji Matsui (@kozy_kekyo, @kekyo@mastodon.cloud)
//
// Licensed under Apache-v2: https://opensource.org/licenses/Apache-2.0
//
////////////////////////////////////////////////////////////////////////////

using System;

namespace FlashCap
{
    public interface ICaptureDevice : IDisposable
    {
        VideoCharacteristics Characteristics { get; }
        bool IsRunning { get; }

        event EventHandler<FrameArrivedEventArgs> FrameArrived;

        void Start();
        void Stop();

        void Capture(IntPtr pData, int size, TimeSpan timestamp, PixelBuffer buffer);
    }
}
