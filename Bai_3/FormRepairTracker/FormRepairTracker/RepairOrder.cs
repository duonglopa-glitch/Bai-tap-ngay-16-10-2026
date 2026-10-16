using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RepairServiceApp
{
    public class RepairOrder : INotifyPropertyChanged
    {
        private string _orderId;
        private string _customerName;
        private string _phoneNumber;
        private string _deviceType;
        private string _issueDescription;
        private DateTime _receivedDate;
        private decimal _estimatedCost;
        private string _status;
        private string _imagePath;

        public string OrderId
        {
            get => _orderId;
            set { _orderId = value; OnPropertyChanged(); }
        }

        public string CustomerName
        {
            get => _customerName;
            set { _customerName = value; OnPropertyChanged(); }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set { _phoneNumber = value; OnPropertyChanged(); }
        }

        public string DeviceType
        {
            get => _deviceType;
            set { _deviceType = value; OnPropertyChanged(); }
        }

        public string IssueDescription
        {
            get => _issueDescription;
            set { _issueDescription = value; OnPropertyChanged(); }
        }

        public DateTime ReceivedDate
        {
            get => _receivedDate;
            set { _receivedDate = value; OnPropertyChanged(); }
        }

        public decimal EstimatedCost
        {
            get => _estimatedCost;
            set { _estimatedCost = value; OnPropertyChanged(); }
        }

        public string Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(); }
        }

        public string ImagePath
        {
            get => _imagePath;
            set { _imagePath = value; OnPropertyChanged(); }
        }

        public RepairOrder() { }

        public RepairOrder(string orderId, string customerName, string phoneNumber, string deviceType,
                           string issueDescription, DateTime receivedDate, decimal estimatedCost,
                           string status, string imagePath = "")
        {
            _orderId = orderId;
            _customerName = customerName;
            _phoneNumber = phoneNumber;
            _deviceType = deviceType;
            _issueDescription = issueDescription;
            _receivedDate = receivedDate;
            _estimatedCost = estimatedCost;
            _status = status;
            _imagePath = imagePath;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}