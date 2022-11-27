

namespace TrabalhandoComVetores {
    internal class Student {
        public string Name {  get; set; }   
        public int Age { get; private set; }
        public int RoomNumber { get; set; } 

        public Student(string name, int age, int roomNumber) {
            Name = name;
            Age = age;
            RoomNumber = roomNumber;    
        }
        override
        public string ToString() {
            return " Student " + "\n Name: " + Name +
                   "\n Idade: " + Age + "\n Room Number: " + RoomNumber +"\n";
        }
    }
}
