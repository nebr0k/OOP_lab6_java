import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Man person = new Man();
        System.out.print("Enter person's name: ");
        person.setName(scanner.nextLine());
        System.out.print("Enter person's age: ");
        person.setAge(scanner.nextInt());
        scanner.nextLine();
        System.out.print("Enter person's gender: ");
        person.setGender(scanner.nextLine().charAt(0));
        System.out.print("Enter person's weight: ");
        person.setWeight(scanner.nextDouble());
        scanner.nextLine();

        Student student = new Student();
        student.setPerson(person);
        System.out.print("Enter enrollment year: ");
        student.setEnrollmentYear(scanner.nextInt());
        scanner.nextLine();

        System.out.println("Student's name: " + student.getPerson().getName());
        System.out.println("Enrollment year: " + student.getEnrollmentYear());

        System.out.print("Enter new name: ");
        student.getPerson().setName(scanner.nextLine());
        System.out.print("Enter new age: ");
        student.getPerson().setAge(scanner.nextInt());
        scanner.nextLine();
        System.out.print("Enter new weight: ");
        student.getPerson().setWeight(scanner.nextDouble());
        scanner.nextLine();
        student.increaseEnrollmentYear();

        System.out.println("Updated student's name: " + student.getPerson().getName());
        System.out.println("Updated student's age: " + student.getPerson().getAge());
        System.out.println("Updated student's weight: " + student.getPerson().getWeight());
        System.out.println("Updated enrollment year: " + student.getEnrollmentYear());

        
    }
}
