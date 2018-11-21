namespace csharp {
    public class Contacts {
        public class Info {
            public string FirstName { get;  set; }
            public string LastName { get;  set; }
            public string TwitterHandle { get;  set; }
        }

        public static Info get(string name) {
            Info info = new Info() { FirstName = "Paul",
                LastName = "Moore", 
                TwitterHandle = "@pdmoore"
            };

            return info;
        }
    }
}