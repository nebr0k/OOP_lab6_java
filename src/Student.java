public class Student {
    private Man person;
    private int enrollmentYear;

    public void setPerson(Man newPerson) {
        person = newPerson;
    }

    public void setEnrollmentYear(int newYear) {
        enrollmentYear = newYear;
    }

    public Man getPerson() {
        return person;
    }

    public int getEnrollmentYear() {
        return enrollmentYear;
    }

    public void increaseEnrollmentYear() {
        enrollmentYear++;
    }
}
