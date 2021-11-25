using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;

namespace BluetoothHandler
{
    public class Bluetooth
    {
        static DeviceInformation device = null;

        public static string SP110E_SERVICE_ID = "ffe0";
        public static GattCharacteristic ffe1 = null;
        public static GattCharacteristic ffe2 = null;
        public static List<BluetoothLedStrip> ledStrips = new List<BluetoothLedStrip>();

        static async Task Main(string[] args) {

        }
    }
}
