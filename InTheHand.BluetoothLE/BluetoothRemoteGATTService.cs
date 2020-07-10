﻿//-----------------------------------------------------------------------
// <copyright file="BluetoothRemoteGATTService.cs" company="In The Hand Ltd">
//   Copyright (c) 2018-19 In The Hand Ltd, All rights reserved.
//   This source code is licensed under the MIT License - see License.txt
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InTheHand.Bluetooth.GenericAttributeProfile
{
    public sealed partial class BluetoothRemoteGATTService
    {
        internal BluetoothRemoteGATTService(BluetoothDevice device)
        {
            Device = device;
        }

        public BluetoothDevice Device { get; private set; }

        public Guid Uuid { get { return GetUuid(); } }

        public bool IsPrimary { get { return GetIsPrimary(); } }

        public Task<GattCharacteristic> GetCharacteristicAsync(Guid characteristic)
        {
            return DoGetCharacteristic(characteristic);
        }

        public Task<IReadOnlyList<GattCharacteristic>> GetCharacteristicsAsync()
        {
            return DoGetCharacteristics();
        }

        public Task<BluetoothRemoteGATTService> GetIncludedServiceAsync(Guid service)
        {
            return DoGetIncludedServiceAsync(service);
        }

        public Task<IReadOnlyList<BluetoothRemoteGATTService>> GetIncludedServicesAsync()
        {
            return DoGetIncludedServicesAsync();
        }

        public event EventHandler ServiceAdded;
        public event EventHandler ServiceChanged;
        public event EventHandler ServiceRemoved;
    }
}
