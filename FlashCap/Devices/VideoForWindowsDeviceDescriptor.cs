﻿////////////////////////////////////////////////////////////////////////////
//
// FlashCap - Independent camera capture library.
// Copyright (c) Kouji Matsui (@kozy_kekyo, @kekyo@mastodon.cloud)
//
// Licensed under Apache-v2: https://opensource.org/licenses/Apache-2.0
//
////////////////////////////////////////////////////////////////////////////

namespace FlashCap.Devices
{
    public sealed class VideoForWindowsDeviceDescriptor : CaptureDeviceDescriptor
    {
        private readonly int deviceIndex;

        internal VideoForWindowsDeviceDescriptor(
            int deviceIndex, string name, string description,
            VideoCharacteristics[] characteristics) :
            base(name, description, characteristics) =>
            this.deviceIndex = deviceIndex;

        public override object Identity =>
            this.deviceIndex;

        public override DeviceTypes DeviceType =>
            DeviceTypes.VideoForWindows;

        public override unsafe ICaptureDevice Open(
            VideoCharacteristics characteristics,
            bool transcodeIfYUV = true) =>
            new VideoForWindowsDevice(this.deviceIndex, characteristics, transcodeIfYUV);
    }
}