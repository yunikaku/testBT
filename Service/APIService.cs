using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testBT.Models;
using System.Net;
using System.IdentityModel.Tokens.Jwt;



namespace testBT.Service
{
    internal class APIService : InterfaceAPI
    {
        private string _baseUrl = "https://localhost:7117/api/";


        public async Task<bool> AddStatus(PostStatus postStatus)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Status;
                var json = JsonConvert.SerializeObject(postStatus);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddSection(PostSection postSection)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Section;
                var json = JsonConvert.SerializeObject(postSection);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddNFC(PostNFC postNFC)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.NFC;
                var json = JsonConvert.SerializeObject(postNFC);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddEmployeeReservation(PostEmployeeReservation postEmployeeReservation)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.EmployeeReservation;
                var json = JsonConvert.SerializeObject(postEmployeeReservation);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddDevice(PostDevice postDevice)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Device;
                var json = JsonConvert.SerializeObject(postDevice);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddDepartment(PostDepartment postDepartment)
        {
            using (var client =new HttpClient()) 
            {
                var url = _baseUrl + APIs.Department;
                var json = JsonConvert.SerializeObject(postDepartment);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public async Task<bool> AddClientCompany(PostClientCompany postClientCompany)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ClientCompany;
                var json = JsonConvert.SerializeObject(postClientCompany);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddClientCompanyEmployee(PostClientCompanyEmployee postClientCompanyEmployee)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ClientCompanyEmployee;
                var json = JsonConvert.SerializeObject(postClientCompanyEmployee);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddConferenceRoom(PostConferenceRoom postConferenceRoom)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ConferenceRoom;
                var json = JsonConvert.SerializeObject(postConferenceRoom);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<List<ClientCompany>> GetClientCompanies(SearchClientCompany searchClientCompany)
        {
            using (var client =new HttpClient()) 
            {
                try 
                {
                    var Id =searchClientCompany.Id;
                    var Name = searchClientCompany.Name;
                    var url = _baseUrl + APIs.ClientCompany + "?Id=" + Id + "&Name=" + Name;
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        var re = await response.Content.ReadAsStringAsync();
                        List<ClientCompany> clientCompanies = JsonConvert.DeserializeObject<List<ClientCompany>>(re);
                        return clientCompanies;
                    }
                    else
                    {
                        return null;
                    }

                }
                catch (System.Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
                    return null;
                }

            }
        }

        public async Task<List<ClientCompanyEmployee>> GetClientCompanyEmployees(SearchClientCompanyEmployee searchClientCompanyEmployee)
        {
            using (var client = new HttpClient())
            {
                var Id = WebUtility.UrlEncode(searchClientCompanyEmployee.Id.ToString());
                var Name = WebUtility.UrlEncode(searchClientCompanyEmployee.Name);    
                var NameKana = WebUtility.UrlEncode(searchClientCompanyEmployee.NameKana);
                var ClientCompanyId = WebUtility.UrlEncode(searchClientCompanyEmployee.ClientCompanyId.ToString());
                var Section = WebUtility.UrlEncode(searchClientCompanyEmployee.Section);
                var Position = WebUtility.UrlEncode(searchClientCompanyEmployee.Position);
                var url = _baseUrl + APIs.ClientCompanyEmployee+ "?Id=" + Id + "&Name=" + Name + "&NameKana=" + NameKana + "&ClientCompanyId=" + ClientCompanyId + "&Section="+Section+ "&Position="+Position;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var re = await response.Content.ReadAsStringAsync();
                    List<ClientCompanyEmployee> clientCompanyEmployees = JsonConvert.DeserializeObject<List<ClientCompanyEmployee>>(re);
                    return clientCompanyEmployees;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<ConferenceRoom>> GetConferenceRooms(SearchConferenceRoom searchConferenceRoom)
        {
            using (var client = new HttpClient())
            {
                var ConferenceRoomId =searchConferenceRoom.ConferenceRoomId;
                var ConferenceRoomName = WebUtility.UrlEncode( searchConferenceRoom.ConferenceRoomName);
                var ConferenceRoomCapacity = searchConferenceRoom.ConferenceRoomCapacity;
                var url = _baseUrl + APIs.ConferenceRoom + "?ConferenceRoomId=" + ConferenceRoomId + "&ConferenceRoomName=" + ConferenceRoomName + "&ConferenceRoomCapacity=" + ConferenceRoomCapacity;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var re = await response.Content.ReadAsStringAsync();
                    List<ConferenceRoom> conferenceRooms = JsonConvert.DeserializeObject<List<ConferenceRoom>>(re);
                    return conferenceRooms;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Department>> GetDepartments(SearchDepartment searchDepartment)
        {
            using(var client = new HttpClient()) 
            {
                var DepartmentId = searchDepartment.DepartmentId;
                var DepartmentName = WebUtility.UrlEncode(searchDepartment.DepartmentName);
                var url = _baseUrl + APIs.Department + "?DepartmentId=" + DepartmentId + "&DepartmentName=" + DepartmentName;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var re = await response.Content.ReadAsStringAsync();
                    List<Department> departments = JsonConvert.DeserializeObject<List<Department>>(re);
                    return departments;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Models.Device>> GetDevices(SearchDevice searchDevice)
        {
            using (var client = new HttpClient())
            {
                var DeviceId = searchDevice.DeviceId;
                var DeviceName = WebUtility.UrlEncode(searchDevice.DeviceName);
                var DeviceLocation = WebUtility.UrlEncode(searchDevice.DeviceLocation);
                var url = _baseUrl + APIs.Device + "?DeviceId=" + DeviceId + "&DeviceName=" + DeviceName + "&DeviceLocation=" + DeviceLocation;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var re = await response.Content.ReadAsStringAsync();
                    List<Models.Device> devices = JsonConvert.DeserializeObject<List<Models.Device>>(re);
                    return devices;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<EmployeeReservation>> GetEmployeeReservations(SearchEmployeeReservation searchEmployeeReservation)
        {
            using (var client = new HttpClient()) 
            {
                var EmployeeReservationsId = searchEmployeeReservation.EmployeeReservationsId;
                var UserId = WebUtility.UrlEncode(searchEmployeeReservation.UserId);
                var ClientCompanyEmployeesId = searchEmployeeReservation.ClientCompanyEmployeesId;
                var CompleteFlag = WebUtility.UrlEncode(searchEmployeeReservation.CompleteFlag);
                var Requirement = WebUtility.UrlEncode(searchEmployeeReservation.Requirement);
                var url = _baseUrl + APIs.EmployeeReservation + "?EmployeeReservationsId=" + EmployeeReservationsId + "&UserId=" + UserId + "&ClientCompanyEmployeesId=" + ClientCompanyEmployeesId + "&CompleteFlag=" + CompleteFlag + "&Requirement=" + Requirement;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var re = await response.Content.ReadAsStringAsync();
                    List<EmployeeReservation> employeeReservations = JsonConvert.DeserializeObject<List<EmployeeReservation>>(re);
                    return employeeReservations;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<EnteringAndLeaving>> GetEnteringAndLeaving(SearchEnteringAndLeaving searchEnteringAndLeaving)
        {
            using (var client =new HttpClient()) 
            {
                var EnteringAndLeavingId = searchEnteringAndLeaving.EnteringAndLeavingId;
                var DeviceId = searchEnteringAndLeaving.DeviceId;
                var NfcUid = WebUtility.UrlEncode(searchEnteringAndLeaving.NfcUid);
                var UserId = WebUtility.UrlEncode(searchEnteringAndLeaving.UserId);
                var UserName = WebUtility.UrlEncode(searchEnteringAndLeaving.UserName);
                var ClientCompanyEmployeesId = searchEnteringAndLeaving.ClientCompanyEmployeesId;
                var ClientCompanyEmployeesName = WebUtility.UrlEncode(searchEnteringAndLeaving.ClientCompanyEmployeesName);
                var StatusId = searchEnteringAndLeaving.StatusId;
                var CompleteFlg = searchEnteringAndLeaving.CompleteFlg;
                var StartTime = searchEnteringAndLeaving.StartTime;
                var EndTime = searchEnteringAndLeaving.EndTime;
                var url = _baseUrl + APIs.EnteringAndLeaving + "?EnteringAndLeavingId=" + EnteringAndLeavingId + "&DeviceId=" + DeviceId + "&NfcUid=" + NfcUid + "&UserId=" + UserId + "&UserName=" + UserName + "&ClientCompanyEmployeesId=" + ClientCompanyEmployeesId + "&ClientCompanyEmployeesName=" + ClientCompanyEmployeesName + "&StatusId=" + StatusId + "&CompleteFlg=" + CompleteFlg + "&StartTime=" + StartTime + "&EndTime=" + EndTime;
                var response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var re = await response.Content.ReadAsStringAsync();
                    List<EnteringAndLeaving> enteringAndLeavings = JsonConvert.DeserializeObject<List<EnteringAndLeaving>>(re);
                    return enteringAndLeavings;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<NFC>> GetNFC(SearchNFC searchNFC)
        {
            using (var client = new HttpClient())
            {
                var UserName =WebUtility.UrlEncode(searchNFC.UserName);
                var ClientCompanyEmployeesName = WebUtility.UrlEncode(searchNFC.ClientCompanyEmployeesName);
                var CardUid = WebUtility.UrlEncode(searchNFC.NfcUid);
                var url = _baseUrl + APIs.NFC+"?CardUid="+CardUid+"&UserName=" +UserName+ "&ClientCompanyEmployeesName="+ ClientCompanyEmployeesName ;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var re = await response.Content.ReadAsStringAsync();
                   List<NFC> nfc = JsonConvert.DeserializeObject<List<NFC>>(re);
                    return nfc;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Section>> GetSections(SearchSection searchSection)
        {
            using (var client=new HttpClient()) 
            {
                var SectionId = searchSection.SectionId;
                var SectionName = WebUtility.UrlEncode(searchSection.SectionName);
                var DepartmentId = searchSection.DepartmentId;
                var DepartmentName = WebUtility.UrlEncode(searchSection.DepartmentName);
                var url = _baseUrl + APIs.Section + "?SectionId=" + SectionId + "&SectionName=" + SectionName + "&DepartmentId=" + DepartmentId + "&DepartmentName=" + DepartmentName;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var re = await response.Content.ReadAsStringAsync();
                    List<Section> sections = JsonConvert.DeserializeObject<List<Section>>(re);
                    return sections;
                }
                else
                {
                    return null;
                }
            }
        }

        public async Task<List<Status>> GetStatus(SearchStatus searchStatus)
        {
            using (var client = new HttpClient())
            {
                var StatusId = searchStatus.StatusId;
                var StatusName = WebUtility.UrlEncode(searchStatus.StatusName);
                var url = _baseUrl + APIs.Status + "?StatusId=" + StatusId + "&StatusName=" + StatusName;
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var re = response.Content.ReadAsStringAsync();
                    List<Status> status = JsonConvert.DeserializeObject<List<Status>>(re.Result);
                    return status;
                }
                else
                {
                    return null;
                }
            }
        }

        

        public async Task<string> Login(LoginModel loginModel)
        {
            using (var client = new HttpClient())
            {

                var url = _baseUrl + APIs.Login;
                var json = JsonConvert.SerializeObject(loginModel);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    
                    var re = await response.Content.ReadAsStringAsync();
                    User user = JsonConvert.DeserializeObject<User>(re);
                    



                    return re;
                }
                else
                {
                    return null;
                }
            }

        }

        public async Task<bool> Login2(LoginModel loginModel)
        {
            using (var client = new HttpClient())
            {

                var url = _baseUrl + APIs.Login;
                var json = JsonConvert.SerializeObject(loginModel);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {

                    var re = await response.Content.ReadAsStringAsync();
                    var jwt = re;
                    var handler = new JwtSecurityTokenHandler();
                    var token = handler.ReadJwtToken(jwt);

                    var claims = token.Claims;
                    var userId = claims.First(claim => claim.Type == "nameid").Value;
                    var userName = claims.First(claim => claim.Type == "unique_name").Value;
                    var userRoles = claims.First(claim => claim.Type == "role").Value;
                    var emal = claims.First(claim => claim.Type == "email").Value;
                    List<string> roles = userRoles.Split(',').ToList();
                    var Expiration = token.ValidTo;

                    UserInfo userdate = new UserInfo
                    {
                        Id = userId,
                        UserName = userName,
                        Role = roles,
                        Expiration = Expiration,
                        Email = emal,
                    };
                    var jsondate = JsonConvert.SerializeObject(userdate);
                    SecureStorage.SetAsync("UserDate",jsondate);




                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public async Task<bool> Logout()
        {
            SecureStorage.Remove("UserDate");
            var data = await SecureStorage.GetAsync("UserDate");
            if (data == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public async Task<bool> Register(PostUser postUser)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Register;
                var json = JsonConvert.SerializeObject(postUser);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Task<UserInfo> GetUserDate()
        {
            var data = SecureStorage.GetAsync("UserDate");
            if (data != null)
            {
                UserInfo userdate = JsonConvert.DeserializeObject<UserInfo>(data.Result);
                return Task.FromResult(userdate);
            }
            else
            {
                return null;
            }
        }

        public Task<bool> PutClientCompany(ClientCompany clientCompany)
        {
            using (var client = new HttpClient()) 
            {
                var url = _baseUrl + APIs.ClientCompany;
                var json = JsonConvert.SerializeObject(clientCompany);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            };
        }

        public Task<ClientCompany> PutgetClientCompany(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ClientCompany + "?Id=" + id;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    
                    var re = response.Result.Content.ReadAsStringAsync();
                    List<ClientCompany> clientCompany = JsonConvert.DeserializeObject<List<ClientCompany>>(re.Result);
                    if (clientCompany.Count > 0)
                    {
                        foreach (var item in clientCompany)
                        {
                            if (item.ClientCompanyId == id) 
                            {
                                return Task.FromResult(item);
                            }
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }




                }
                else
                {
                    return null;
                }
            }
        }


        public Task<bool> DeleteClientCompany(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ClientCompany + "/" + id;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }
    
    
        public Task<bool> PutClientCompanyEmployee(ClientCompanyEmployee clientCompanyEmployee)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ClientCompanyEmployee;
                var json = JsonConvert.SerializeObject(clientCompanyEmployee);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            };
        }

        public Task<ClientCompanyEmployee> PutgetClientCompanyEmployee(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ClientCompanyEmployee + "?Id=" + id;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {

                    var re = response.Result.Content.ReadAsStringAsync();
                    List<ClientCompanyEmployee> clientCompanyEmployee = JsonConvert.DeserializeObject<List<ClientCompanyEmployee>>(re.Result);
                    if (clientCompanyEmployee.Count > 0)
                    {
                        foreach (var item in clientCompanyEmployee)
                        {
                            if (item.ClientCompanyEmployeesId == id)
                            {
                                return Task.FromResult(item);
                            }
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<bool> DeleteClientCompanyEmployee(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ClientCompanyEmployee + "/" + id;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }
    
    
        public Task<bool> PutConferenceRoom(ConferenceRoom conferenceRoom)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ConferenceRoom;
                var json = JsonConvert.SerializeObject(conferenceRoom);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            };
        }

        public Task<ConferenceRoom> PutgetConferenceRoom(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ConferenceRoom + "?Id=" + id;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {

                    var re = response.Result.Content.ReadAsStringAsync();
                    List<ConferenceRoom> conferenceRoom = JsonConvert.DeserializeObject<List<ConferenceRoom>>(re.Result);
                    if (conferenceRoom.Count > 0)
                    {
                        foreach (var item in conferenceRoom)
                        {
                            if (item.ConferenceRoomId == id)
                            {
                                return Task.FromResult(item);
                            }
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<bool> DeleteConferenceRoom(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.ConferenceRoom + "/" + id;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<bool> PutDepartment(Department department)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Department;
                var json = JsonConvert.SerializeObject(department);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            };
        }

        public Task<Department> PutgetDepartment(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Department + "?Id=" + id;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {

                    var re = response.Result.Content.ReadAsStringAsync();
                    List<Department> department = JsonConvert.DeserializeObject<List<Department>>(re.Result);
                    if (department.Count > 0)
                    {
                        foreach (var item in department)
                        {
                            if (item.DepartmentId == id)
                            {
                                return Task.FromResult(item);
                            }
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<bool> DeleteDepartment(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Department + "/" + id;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<bool> PutDevice(Models.Device device)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Device;
                var json = JsonConvert.SerializeObject(device);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            };
        }

        public Task<Models.Device> PutgetDevice(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Device + "?Id=" + id;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {

                    var re = response.Result.Content.ReadAsStringAsync();
                    List<Models.Device> device = JsonConvert.DeserializeObject<List<Models.Device>>(re.Result);
                    if (device.Count > 0)
                    {
                        foreach (var item in device)
                        {
                            if (item.DeviceId == id)
                            {
                                return Task.FromResult(item);
                            }
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<bool> DeleteDevice(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Device + "/" + id;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<bool> PutEmployeeReservation(EmployeeReservation employeeReservation)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.EmployeeReservation;
                var json = JsonConvert.SerializeObject(employeeReservation);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            };
        }

        public Task<EmployeeReservation> PutgetEmployeeReservation(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.EmployeeReservation + "?Id=" + id;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {

                    var re = response.Result.Content.ReadAsStringAsync();
                    List<EmployeeReservation> employeeReservation = JsonConvert.DeserializeObject<List<EmployeeReservation>>(re.Result);
                    if (employeeReservation.Count > 0)
                    {
                        foreach (var item in employeeReservation)
                        {
                            if (item.EmployeeReservationsId == id)
                            {
                                return Task.FromResult(item);
                            }
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<bool> DeleteEmployeeReservation(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.EmployeeReservation + "/" + id;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<bool> SetNFC(NFC NFC)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.NFC;
                var json = JsonConvert.SerializeObject(NFC);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }
        public Task<bool> ResetNFC(string uid) 
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.NFC + "?uid=" + uid;
                var response = client.PutAsync(url, null);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<bool> DeleteNFC(string uid)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.NFC + "/" + uid;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<NFC> SetgetNFC(string uid)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.NFC + "?uid=" + uid;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    var re = response.Result.Content.ReadAsStringAsync();
                    NFC nfc = JsonConvert.DeserializeObject<NFC>(re.Result);
                    if (nfc != null)
                    {
                        return Task.FromResult(nfc);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<Section> PutgetSection(int id) 
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Section + "?Id=" + id;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    var re = response.Result.Content.ReadAsStringAsync();
                    List<Section> section = JsonConvert.DeserializeObject<List<Section>>(re.Result);
                    if (section.Count > 0)
                    {
                        foreach (var item in section)
                        {
                            if (item.SectionId == id)
                            {
                                return Task.FromResult(item);
                            }
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<bool> PutSection(Section section)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Section;
                var json = JsonConvert.SerializeObject(section);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<bool> DeleteSection(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Section + "/" + id;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<bool> PutStatus(Status status)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Status;
                var json = JsonConvert.SerializeObject(status);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync(url, content);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }

        public Task<Status> PutgetStatus(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Status + "?Id=" + id;
                var response = client.GetAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    var re = response.Result.Content.ReadAsStringAsync();
                    List<Status> status = JsonConvert.DeserializeObject<List<Status>>(re.Result);
                    if (status.Count > 0)
                    {
                        foreach (var item in status)
                        {
                            if (item.StatusId == id)
                            {
                                return Task.FromResult(item);
                            }
                        }
                        return null;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        public Task<bool> DeleteStatus(int id)
        {
            using (var client = new HttpClient())
            {
                var url = _baseUrl + APIs.Status + "/" + id;
                var response = client.DeleteAsync(url);
                if (response.Result.IsSuccessStatusCode)
                {
                    return Task.FromResult(true);
                }
                else
                {
                    return Task.FromResult(false);
                }
            }
        }
    }
}

