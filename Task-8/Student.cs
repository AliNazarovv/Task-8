namespace Task_8
{
    class Student
    {
       public string id;
       public string name;
       public string surname;
        public string birthOfDate;
        public override string ToString()
        {
            return $"ID: {this.id} Name: {this.name} Surname:  {this.surname} birthOfDate:  {this.birthOfDate}";
        }
    }
}
