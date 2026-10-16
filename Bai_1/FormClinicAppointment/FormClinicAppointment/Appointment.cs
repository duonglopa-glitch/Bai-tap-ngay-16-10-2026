using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClinicManagerApp
{
    public class Appointment : INotifyPropertyChanged
    {
        private string _appointmentId;
        private string _patientName;
        private string _phoneNumber;
        private DateTime _appointmentDate;
        private string _doctor;
        private string _reason;
        private string _status;

        public string AppointmentId
        {
            get => _appointmentId;
            set { _appointmentId = value; OnPropertyChanged(); }
        }

        public string PatientName
        {
            get => _patientName;
            set { _patientName = value; OnPropertyChanged(); }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set { _phoneNumber = value; OnPropertyChanged(); }
        }

        public DateTime AppointmentDate
        {
            get => _appointmentDate;
            set { _appointmentDate = value; OnPropertyChanged(); }
        }

        public string Doctor
        {
            get => _doctor;
            set { _doctor = value; OnPropertyChanged(); }
        }

        public string Reason
        {
            get => _reason;
            set { _reason = value; OnPropertyChanged(); }
        }

        public string Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(); }
        }

        public Appointment() { }

        public Appointment(string id, string name, string phone, DateTime date, string doctor, string reason, string status)
        {
            _appointmentId = id;
            _patientName = name;
            _phoneNumber = phone;
            _appointmentDate = date;
            _doctor = doctor;
            _reason = reason;
            _status = status;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}