﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IoTDevicesService.DataObjects
{
    using Microsoft.Azure.Mobile.Server;
    public class DeviceEntry : EntityData
    {
        public string DeviceId { get; set; }
        public bool ServiceAvailable { get; set; }
        public string IoTHubEndpoint { get; set; }
        public string DeviceKey { get; set; }
    }
}