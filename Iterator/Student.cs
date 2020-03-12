public class Student{
    private string name;
    private int sex; //男の子:1  女の子:2
 
    public Student(string name,int sex){
        this.name = name;
        this.sex = sex;
    }
    public string getName(){
        return name;
    }
    public int getSex(){
        return sex;
    }
}