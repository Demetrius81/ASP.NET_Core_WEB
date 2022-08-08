using TimeSheets.Models;

namespace TimeSheets.Data
{
    public class TempData
    {
        public List<User> users = new List<User>()
        {
			new User() {
				Id = Guid.Parse("DE16FD13-EB62-5A8A-B1C9-39EEF70F7BB0"),
				UserName = "Kenneth",
				FirstName = "Rinah",
				LastName = "Valenzuela",
				Email = "ut.pharetra.sed@outlook.ca",
				Company = "Tincidunt Tempus Ltd",
				Age = 35
			},
			new User() {
				Id = Guid.Parse("CB59B8A1-46BD-CBF9-27C7-85B90DD51BB7"),
				UserName = "Cain",
				FirstName = "Michelle",
				LastName = "Carter",
				Email = "neque.venenatis@hotmail.com",
				Company = "Dolor Quam Consulting",
				Age = 51
			},
			new User() {
				Id = Guid.Parse("A725E5C3-EC71-6413-92C4-914A4BA220D6"),
				UserName = "Maggy",
				FirstName = "Wynne",
				LastName = "Carrillo",
				Email = "convallis.ligula.donec@yahoo.com",
				Company = "Magna Corporation",
				Age = 20
			},
			new User() {
				Id = Guid.Parse("19DE84E3-EB1E-9C3C-3C74-C22584B63E14"),
				UserName = "Quinn",
				FirstName = "Tucker",
				LastName = "Short",
				Email = "quisque.imperdiet@protonmail.org",
				Company = "Ut Ltd",
				Age = 52
			},
			new User() {
				Id = Guid.Parse("68C29ED2-7AE6-C67B-5735-5514DB515474"),
				UserName = "Martin",
				FirstName = "Hiroko",
				LastName = "Duffy",
				Email = "dapibus.gravida@icloud.ca",
				Company = "Molestie LLC",
				Age = 48
			},
			new User() {
				Id = Guid.Parse("A823C61E-AC8E-B1C1-0232-6AAA4087A95E"),
				UserName = "Sybill",
				FirstName = "Jaime",
				LastName = "Jimenez",
				Email = "risus.donec.egestas@icloud.net",
				Company = "A Incorporated",
				Age = 54
			},
			new User() {
				Id = Guid.Parse("78D4BF69-83A4-98CB-99EE-2B977BB90DC4"),
				UserName = "Anthony",
				FirstName = "Mira",
				LastName = "Dunlap",
				Email = "commodo@icloud.com",
				Company = "Urna Vivamus Molestie Limited",
				Age = 23
			},
			new User() {
				Id = Guid.Parse("F2175E9A-29BE-8CDD-CE18-6253F35B2E2D"),
				UserName = "Ahmed",
				FirstName = "Rhiannon",
				LastName = "Pittman",
				Email = "sapien.cursus@hotmail.com",
				Company = "Rutrum Lorem Inc.",
				Age = 43
			},
			new User() {
				Id = Guid.Parse("1AA18E28-ED3B-7295-D627-B9CE1FCA0C12"),
				UserName = "Jack",
				FirstName = "Leandra",
				LastName = "Boyd",
				Email = "dictum.proin@google.org",
				Company = "Placerat Velit Incorporated",
				Age = 39
			},
			new User() {
				Id = Guid.Parse("3A45810E-E9CB-6066-7457-89CF7674CD98"),
				UserName = "Moses",
				FirstName = "Robin",
				LastName = "Acevedo",
				Email = "gravida@icloud.couk",
				Company = "Leo Elementum Consulting",
				Age = 38
			}
		};

        public List<Client> clients = new List<Client>()
        {
			new Client() {
				Id = Guid.Parse("BC7D62C6-E738-E518-1843-86309E761490"),
				UserId = Guid.Parse("E70529BA-84D5-524C-3782-858F63939037")
			},
			new Client() {
				Id = Guid.Parse("95A87F03-2C26-5BBB-2AD6-DF971A542867"),
				UserId = Guid.Parse("D127BD32-EEC9-9CAB-517C-231A933B0B1A")
			},
			new Client() {
				Id = Guid.Parse("B6B77F34-276A-1ADA-9166-BE475FB7BA90"),
				UserId = Guid.Parse("EF22A520-3256-BB87-6735-0DEE374A88DD")
			},
			new Client() {
				Id = Guid.Parse("187B3548-6A99-6776-E435-1262C076617A"),
				UserId = Guid.Parse("186D51F1-E194-C704-5A93-7395471DD5DA")
			},
			new Client() {
				Id = Guid.Parse("E55294A5-8713-507B-3BC4-8778C1BD4C26"),
				UserId = Guid.Parse("8D8955E9-BAD3-CF0E-C676-A292835F71A9")
			},
			new Client() {
				Id = Guid.Parse("51B62AC3-FC92-A26E-E46C-CAD7CD1C4A24"),
				UserId = Guid.Parse("FEE44008-2B6B-0DB5-699A-A7FE9AA81571")
			},
			new Client() {
				Id = Guid.Parse("6178CE96-F27E-9E29-06EE-1623BD1324D9"),
				UserId = Guid.Parse("1B64CFF0-57D5-8147-7760-38A1D728234B")
			},
			new Client() {
				Id = Guid.Parse("25B69391-E919-35E4-AD5D-3BE3C965353C"),
				UserId = Guid.Parse("F5429442-35BC-C25C-8A47-C91D339D6A41")
			},
			new Client() {
				Id = Guid.Parse("BE2A45BF-7E24-37C8-02BA-394A21CB79E7"),
				UserId = Guid.Parse("3059AB36-567C-3277-A2AA-94AE6F8E77E6")
			},
			new Client() {
				Id = Guid.Parse("BCCA66B7-8629-2DA7-282B-50CDEB3AF159"),
				UserId = Guid.Parse("DF662409-6BAA-1065-67C8-AEF2839ECE2A")
			}
		};

        public List<Employee> employes = new List<Employee>()
        {
			new Employee() {
				Id = Guid.Parse("64A9393C-80D6-E9A2-55EC-98BBDCDE1E5E"),
				UserId = Guid.Parse("63B1D427-B6E7-EFAC-AD2C-132EDC636E4B")
			},
			new Employee() {
				Id = Guid.Parse("266E5B51-C6AD-CD28-DCE8-95B2D92A5663"),
				UserId = Guid.Parse("8EE01782-955F-7DC8-565D-9C35E0DE5E3D")
			},
			new Employee() {
				Id = Guid.Parse("2C3D3538-BDC1-7D8B-29B6-53B7D959BEE6"),
				UserId = Guid.Parse("D3622B66-5371-A1A7-6E4B-21A58EC04F92")
			},
			new Employee() {
				Id = Guid.Parse("5E7005C5-A3B3-C8DF-6F66-EE1E95C58875"),
				UserId = Guid.Parse("1EAE2411-5C55-37BC-A5ED-91C6A7D21785")
			},
			new Employee() {
				Id = Guid.Parse("02E4DC39-CC87-79CE-C2C7-1E4376F3B7A2"),
				UserId = Guid.Parse("3672552E-3513-BA4D-EAD3-37C1269B1E18")
			},
			new Employee() {
				Id = Guid.Parse("76102CBD-85AE-98ED-33D9-A192856C23E9"),
				UserId = Guid.Parse("441366FC-6424-8840-7E9E-1E89D68354BE")
			},
			new Employee() {
				Id = Guid.Parse("0BEC7193-7B29-29A5-DE44-4CC6DB89A9DE"),
				UserId = Guid.Parse("59AFA909-4AA5-9034-90E2-AE9236BCB58F")
			},
			new Employee() {
				Id = Guid.Parse("66D73984-C4CE-9CA5-4C5D-B2985CC0CAE2"),
				UserId = Guid.Parse("0562A6E9-CE73-86BF-86AE-EB63AE3C44AE")
			},
			new Employee() {
				Id = Guid.Parse("5BE76906-E717-CB90-A6B6-9BBCAD91AE8B"),
				UserId = Guid.Parse("7DAEE68B-CCAD-2225-0B6B-37FD4E062CA3")
			},
			new Employee() {
				Id = Guid.Parse("765CB97A-84D0-0EB4-4D9C-F6B517065C8D"),
				UserId = Guid.Parse("713B84AE-C88D-4894-2864-86CBB61E1BDC")
			}
		};

        public List<Contract> contracts = new List<Contract>()
        {
			new Contract() {
				Id = Guid.Parse("BD1CAA6F-4651-3D2C-AE1E-0EB2DCB72A7E"),
				Title = "lacus pede",
				DateStart = DateTime.Parse("14:10:43"),
				DateEnd = DateTime.Parse("22:50:10"),
				Description = "urna, nec luctus felis purus",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Indigo"
					}
				}
			},
			new Contract() {
				Id = Guid.Parse("7F65E75D-9973-E140-83C7-C32F8B6F58A8"),
				Title = "orci sem",
				DateStart = DateTime.Parse("15:25:36"),
				DateEnd = DateTime.Parse("22:48:15"),
				Description = "libero mauris, aliquam eu, accumsan",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Emery"
					}
				}
			},
			new Contract() {
				Id = Guid.Parse("38BC8FEA-B133-A742-48EA-841856A666E1"),
				Title = "turpis egestas.",
				DateStart = DateTime.Parse("13:38:49"),
				DateEnd = DateTime.Parse("2:23:30"),
				Description = "Sed pharetra, felis eget varius",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Armand"
					}
				}
			},
			new Contract() {
				Id = Guid.Parse("862ED489-CE2D-2427-FA20-E302299685B9"),
				Title = "Cum sociis",
				DateStart = DateTime.Parse("7:16:08"),
				DateEnd = DateTime.Parse("3:32:10"),
				Description = "ipsum. Suspendisse non leo. Vivamus",
				Services = new List<Service>(){
				new 	Service()
					{
						Id = Guid.NewGuid(),
						Name = "Joy"}
				}
			}
			,
			new Contract() {
				Id = Guid.Parse("7B4C5CB1-7712-6C32-E3DD-EE9922D6BC02"),
				Title = "nibh vulputate",
				DateStart = DateTime.Parse("10:06:09"),
				DateEnd = DateTime.Parse("10:49:14"),
				Description = "Proin vel arcu eu odio",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Aileen"
					}
				}
			},
			new Contract() {
				Id = Guid.Parse("44BDDD65-DB21-8A88-3D36-66AA3F8D9FE3"),
				Title = "turpis. Aliquam",
				DateStart = DateTime.Parse("4:16:18"),
				DateEnd = DateTime.Parse("4:25:10"),
				Description = "Donec egestas. Aliquam nec enim.",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Tate"
					}
				}
			},
			new Contract() {
				Id = Guid.Parse("5F96DE22-1F05-4196-9A84-B4AD7A32758E"),
				Title = "ipsum. Curabitur",
				DateStart = DateTime.Parse("11:46:23"),
				DateEnd = DateTime.Parse("21:34:42"),
				Description = "arcu. Sed eu nibh vulputate",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Ralph"
					}
				}
			},
			new Contract() {
				Id = Guid.Parse("80756784-3F62-8952-11D2-E2329702BCBC"),
				Title = "euismod in,",
				DateStart = DateTime.Parse("20:06:45"),
				DateEnd = DateTime.Parse("0:53:49"),
				Description = "faucibus id, libero. Donec consectetuer",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Kiona"
					}
				}
			},
			new Contract() {
				Id = Guid.Parse("ED5054E7-8A52-CB62-EE48-54AFECD43460"),
				Title = "Suspendisse sagittis.",
				DateStart = DateTime.Parse("5:26:18"),
				DateEnd = DateTime.Parse("12:24:57"),
				Description = "eu odio tristique pharetra. Quisque",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Chaney"
					}
				}
			},
			new Contract() {
				Id = Guid.Parse("39224664-3CAC-643C-9E3D-C8DD14694D9E"),
				Title = "in consequat",
				DateStart = DateTime.Parse("16:03:41"),
				DateEnd = DateTime.Parse("4:53:56"),
				Description = "sagittis felis. Donec tempor, est",
				Services = new List<Service>(){
					new Service()
					{
						Id = Guid.NewGuid(),
						Name = "Flavia"
					}
				}
			}
		};

        public List<Service> services = new List<Service>()
        {
			new Service() {
				Id = Guid.Parse("A395C2B1-3DD4-9ED2-2271-884F95D48BEF"),
				Name = "vitae, aliquet"
			},
			new Service() {
				Id = Guid.Parse("52FC979B-A24F-0571-CF8A-CFBE7E6CAA9C"),
				Name = "consectetuer, cursus"
			},
			new Service() {
				Id = Guid.Parse("1856B28C-68A3-2847-F4AE-02875AC13323"),
				Name = "justo. Praesent"
			},
			new Service() {
				Id = Guid.Parse("E2031894-3698-1908-C464-4054125CF429"),
				Name = "leo. Cras"
			},
			new Service() {
				Id = Guid.Parse("CF9BE65D-967D-6D3B-8E23-C68C2BE81948"),
				Name = "et magnis"
			},
			new Service() {
				Id = Guid.Parse("8D31BC7C-E581-6DED-B3EA-374D71782514"),
				Name = "Cras lorem"
			},
			new Service() {
				Id = Guid.Parse("DE866D59-D467-9FDE-251E-995DC77C826B"),
				Name = "mus. Donec"
			},
			new Service() {
				Id = Guid.Parse("2495BE36-DC6B-3512-031C-C84A7FE8932B"),
				Name = "adipiscing, enim"
			},
			new Service() {
				Id = Guid.Parse("88E5E616-414C-BDFC-7C71-B928CFD5AA36"),
				Name = "nisi magna"
			},
			new Service() {
				Id = Guid.Parse("0CDE8D4C-944E-1870-3E28-3416156B3569"),
				Name = "adipiscing elit."
			}
		};

        public List<Sheet> sheets = new List<Sheet>()
        {
			new Sheet() {
				Id = Guid.Parse("DC688439-4C8D-53C7-94A5-DDD74457A579"),
				Date = DateTime.Parse("7:02 AM"),
				EmployeeId = Guid.Parse("9FB3AF32-C1A1-CAE7-02A3-2D2717B10656"),
				ContractId = Guid.Parse("CC29C5E8-755A-D55C-DD3B-3B93D746324D"),
				ServiceId = Guid.Parse("757E1EC9-9E11-15E4-3ADA-29F8CB8241F4"),
				Amount = 8
			},
			new Sheet() {
				Id = Guid.Parse("62ADB7A6-CD06-33B6-33BB-D07D9B927648"),
				Date = DateTime.Parse("8:36 AM"),
				EmployeeId = Guid.Parse("E3B1F913-B7BC-9352-CAD5-406B768C8B13"),
				ContractId = Guid.Parse("14CBA7F7-B4F2-7BB1-59C2-DAAF1E6E90EC"),
				ServiceId = Guid.Parse("BABF2572-0608-ACBB-DD1A-258395B0612B"),
				Amount = 7
			},
			new Sheet() {
				Id = Guid.Parse("16EC1FA3-4802-73C0-9C2D-1F79795BE51C"),
				Date = DateTime.Parse("5:12 AM"),
				EmployeeId = Guid.Parse("A39A44BB-4A76-90C9-C241-F16D777E63A2"),
				ContractId = Guid.Parse("B7404C5A-6D24-A339-2C64-3AC0584153F5"),
				ServiceId = Guid.Parse("3CDEF988-AB9F-F17C-3AAE-388AACB8B09C"),
				Amount = 3
			},
			new Sheet() {
				Id = Guid.Parse("6E34CE3C-B09C-1E48-55AD-1B7CA40BA686"),
				Date = DateTime.Parse("11:37 PM"),
				EmployeeId = Guid.Parse("D2D93788-682D-86E3-B97A-9EB527D92E55"),
				ContractId = Guid.Parse("15DC3057-7143-8E38-5C00-2FC23AE3E057"),
				ServiceId = Guid.Parse("CDFEC29D-922A-2720-9977-DD49AEB53248"),
				Amount = 9
			},
			new Sheet() {
				Id = Guid.Parse("366D1194-4BC2-37D1-F4B9-E35CC3D19A14"),
				Date = DateTime.Parse("2:31 AM"),
				EmployeeId = Guid.Parse("B91BEEEF-BDD8-5669-64A6-6173762E6137"),
				ContractId = Guid.Parse("896B359C-AF68-4E73-8F9A-BBE8284CB5AB"),
				ServiceId = Guid.Parse("35B2C12B-8A9D-BED3-9C89-084407AB7B16"),
				Amount = 3
			},
			new Sheet() {
				Id = Guid.Parse("C4EFDC3F-16ED-3599-8042-CA6DA5684927"),
				Date = DateTime.Parse("3:24 AM"),
				EmployeeId = Guid.Parse("D8956F92-E8D6-9249-B29E-8B95C6F6D60A"),
				ContractId = Guid.Parse("3B777244-5C63-EB72-E410-66B86C8315B6"),
				ServiceId = Guid.Parse("BA6CD99F-465E-6836-EC63-753A433B8967"),
				Amount = 5
			},
			new Sheet() {
				Id = Guid.Parse("CB2D449B-6698-6A8C-86EC-226ABE331DD0"),
				Date = DateTime.Parse("4:24 PM"),
				EmployeeId = Guid.Parse("0EED66F7-6647-E93B-EF6E-EB94EA851729"),
				ContractId = Guid.Parse("DC3D5541-CB61-AB2D-A3D3-4E751A136BA5"),
				ServiceId = Guid.Parse("51D86E1A-1189-36B0-656F-9EDDE8FFC8B1"),
				Amount = 2
			},
			new Sheet() {
				Id = Guid.Parse("B28536C7-92A3-BE1F-1FAD-EA5973B29D57"),
				Date = DateTime.Parse("6:32 PM"),
				EmployeeId = Guid.Parse("785D2D25-B8FF-C231-5CA3-AEE01E386922"),
				ContractId = Guid.Parse("89AFD985-AE2A-84EA-DE37-01968E9C48E1"),
				ServiceId = Guid.Parse("161833DD-1C7E-3D35-2E40-2B465E3DF2F9"),
				Amount = 7
			},
			new Sheet() {
				Id = Guid.Parse("C8B2964C-8629-411E-D861-905EF4C3E3FD"),
				Date = DateTime.Parse("6:20 AM"),
				EmployeeId = Guid.Parse("93C6AB8A-BC28-D4D6-128A-0AB71F2A28A0"),
				ContractId = Guid.Parse("B15BE99D-CB5F-9443-DB77-4B5A8579C0B2"),
				ServiceId = Guid.Parse("196C6407-1C03-5218-5FD8-BC877040E54E"),
				Amount = 1
			},
			new Sheet() {
				Id = Guid.Parse("39F7FC5A-5C9D-76C7-4980-0F3716517D71"),
				Date = DateTime.Parse("5:58 AM"),
				EmployeeId = Guid.Parse("430412D5-B9BD-0B93-526A-3563F0A27759"),
				ContractId = Guid.Parse("4754B801-2601-D663-6CAC-EA61CA36617F"),
				ServiceId = Guid.Parse("B67CDA04-523C-878A-0BBD-07B4E913225D"),
				Amount = 6
			}
		};
    }
}
