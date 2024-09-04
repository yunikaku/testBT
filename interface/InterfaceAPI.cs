using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testBT.Models;

namespace testBT
{
    public interface InterfaceAPI
    {
        public  Task<string> Login(LoginModel loginModel);
        public Task<bool> Login2(LoginModel loginModel);

        public Task<bool> Logout();

        public Task<bool> Register(PostUser postUser);

        public Task<UserInfo> GetUserDate();

        public Task<List<NFC>> GetNFC(SearchNFC searchNFC);

        public Task<bool> AddNFC(PostNFC postNFC);

        public Task<NFC> SetgetNFC(string uid);

        public Task<bool> SetNFC(NFC NFC);

        public Task<bool> ResetNFC(string uid);

        public Task<bool> DeleteNFC(string uid);

        public Task<List<ClientCompany>> GetClientCompanies(SearchClientCompany searchClientCompany);

        public Task<bool> AddClientCompany(PostClientCompany postClientCompany);

        public Task<bool> PutClientCompany(ClientCompany clientCompany);

        public Task<bool> DeleteClientCompany(int id);

        public Task<ClientCompany> PutgetClientCompany(int id);

        public Task<List<ClientCompanyEmployee>> GetClientCompanyEmployees(SearchClientCompanyEmployee searchClientCompanyEmployee);

        public Task<bool> AddClientCompanyEmployee(PostClientCompanyEmployee postClientCompanyEmployee);

        public Task<bool> PutClientCompanyEmployee(ClientCompanyEmployee clientCompanyEmployee);

        public Task<ClientCompanyEmployee> PutgetClientCompanyEmployee(int id);

        public Task<bool> DeleteClientCompanyEmployee(int id);

        public Task<List<ConferenceRoom>> GetConferenceRooms(SearchConferenceRoom searchConferenceRoom);

        public Task<bool> AddConferenceRoom(PostConferenceRoom postConferenceRoom);

        public Task<ConferenceRoom> PutgetConferenceRoom(int id);

        public Task<bool> PutConferenceRoom(ConferenceRoom conferenceRoom);

        public Task<bool> DeleteConferenceRoom(int id);

        

        public Task<List<Department>> GetDepartments(SearchDepartment searchDepartment);

        public Task<bool> AddDepartment(PostDepartment postDepartment);

        public Task<Department> PutgetDepartment(int id);

        public Task<bool> PutDepartment(Department department);

        public Task<bool> DeleteDepartment(int id);

        public Task<List<Models.Device>> GetDevices(SearchDevice searchDevice);

        public Task<bool> AddDevice(PostDevice postDevice);

        public Task<Models.Device> PutgetDevice(int id);

        public Task<bool> PutDevice(Models.Device device);

        public Task<bool> DeleteDevice(int id);

        public Task<List<EmployeeReservation>> GetEmployeeReservations(SearchEmployeeReservation searchEmployeeReservation);

        public Task<bool> AddEmployeeReservation(PostEmployeeReservation postEmployeeReservation);

        public Task<bool> PutEmployeeReservation(EmployeeReservation employeeReservation);

        public Task<EmployeeReservation> PutgetEmployeeReservation(int id);

        public Task<bool> DeleteEmployeeReservation(int id);



        public Task<List<EnteringAndLeaving>> GetEnteringAndLeaving(SearchEnteringAndLeaving searchEnteringAndLeaving);

        public Task<List<Section>> GetSections(SearchSection searchSection);

        public Task<bool> AddSection(PostSection postSection);

        public Task<Section> PutgetSection(int id);

        public Task<bool> PutSection(Section section);

        public Task<bool> DeleteSection(int id);

        public Task<List<Status>> GetStatus(SearchStatus searchStatus);

        public Task<bool> AddStatus(PostStatus postStatus);

        public Task<bool> PutStatus(Status status);

        public Task<Status> PutgetStatus(int id);

        public Task<bool> DeleteStatus(int id);
    }
} 
