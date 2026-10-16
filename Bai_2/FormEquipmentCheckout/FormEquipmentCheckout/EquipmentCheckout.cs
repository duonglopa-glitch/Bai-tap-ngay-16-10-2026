using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LabEquipmentApp
{
    public class EquipmentCheckout : INotifyPropertyChanged
    {
        private string _checkoutId;
        private string _studentId;
        private string _studentName;
        private string _equipmentName;
        private int _quantity;
        private DateTime _checkoutDate;
        private DateTime _dueDate;
        private DateTime? _actualReturnDate;

        public string CheckoutId
        {
            get => _checkoutId;
            set { _checkoutId = value; OnPropertyChanged(); }
        }

        public string StudentId
        {
            get => _studentId;
            set { _studentId = value; OnPropertyChanged(); }
        }

        public string StudentName
        {
            get => _studentName;
            set { _studentName = value; OnPropertyChanged(); }
        }

        public string EquipmentName
        {
            get => _equipmentName;
            set { _equipmentName = value; OnPropertyChanged(); }
        }

        public int Quantity
        {
            get => _quantity;
            set { _quantity = value; OnPropertyChanged(); }
        }

        public DateTime CheckoutDate
        {
            get => _checkoutDate;
            set { _checkoutDate = value; OnPropertyChanged(); }
        }

        public DateTime DueDate
        {
            get => _dueDate;
            set { _dueDate = value; OnPropertyChanged(); }
        }

        public DateTime? ActualReturnDate
        {
            get => _actualReturnDate;
            set
            {
                _actualReturnDate = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Status)); // Cập nhật trạng thái khi ngày trả thay đổi
            }
        }

        /// <summary>
        /// Thuộc tính tự động tính toán Tình trạng mượn thiết bị
        /// </summary>
        public string Status
        {
            get
            {
                if (_actualReturnDate.HasValue) return "Đã trả";
                if (DateTime.Today > _dueDate.Date) return "Quá hạn";
                return "Đang mượn";
            }
        }

        public EquipmentCheckout() { }

        public EquipmentCheckout(string checkoutId, string studentId, string studentName, string equipmentName, int quantity, DateTime checkoutDate, DateTime dueDate, DateTime? actualReturnDate = null)
        {
            _checkoutId = checkoutId;
            _studentId = studentId;
            _studentName = studentName;
            _equipmentName = equipmentName;
            _quantity = quantity;
            _checkoutDate = checkoutDate;
            _dueDate = dueDate;
            _actualReturnDate = actualReturnDate;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}