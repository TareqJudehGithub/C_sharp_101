namespace Inheritance
{
    internal class ElectronicDevice
    {
        // Properties
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        // Constructor
        public ElectronicDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        // Methods
        public void SwitchOn()
        {
            /* This method switches on the device */
            IsOn = true;
        }
        public void SwitchOff()
        {
            /* This method switches off the device */
            IsOn = false;
        }

        public void StartDevice()
        {
            if (IsOn) Console.WriteLine("Starting Device!");
            else Console.WriteLine("Device is switched off, switch it on if you want it to start.");
        }
    }
}
