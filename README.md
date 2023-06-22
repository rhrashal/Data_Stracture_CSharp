# Data_Stracture_CSharp


### CS Mac Address
```cs
        public static string GetMacAddress()
        {
            string macAddresses = "'-1'";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    if (nic.GetPhysicalAddress().ToString().Length > 5)
                    {
                        macAddresses += ",'" + nic.GetPhysicalAddress().ToString() + "'";
                        //break;
                    }
                }
                //if (nic.OperationalStatus == OperationalStatus.Down)
                //{
                //    if (nic.GetPhysicalAddress().ToString().Length > 5)
                //    {
                //        macAddresses += ",'" + nic.GetPhysicalAddress().ToString() + "'";
                //        //break;
                //    }
                //}
            }

            if (macAddresses == "'-1'")
            {
                foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    if (nic.OperationalStatus == OperationalStatus.Down)
                    {
                        if (nic.GetPhysicalAddress().ToString().Length > 10)
                        {
                            macAddresses += ",'" + nic.GetPhysicalAddress().ToString() + "'";
                            //break;
                        }
                    }
                }
            }
            return macAddresses;
        }
```
