using System;

class MedicalBot
{
  public const string BotName = "Bob"; // declaring a constant string variable with the value "Bob" which represents the name of the medical bot.

  // This method prescribes medication based on the symptoms of the patient passed as an argument.
  public void PrescribeMedication(Patient patient)
  {
    if (patient.GetSymptoms() == "Headache") // If the patient's symptoms are headache
    {
      patient.SetPrescription("ibuprofen " + GetDosage("ibuprofen")); // Then prescribe ibuprofen to the patient.
    }
    else if (patient.GetSymptoms() == "Skin rashes") // If the patient's symptoms are skin rashes
    {
      patient.SetPrescription("diphenhydramine " + GetDosage("diphenhydramine")); // Then prescribe diphenhydramine to the patient.
    }
    else if (patient.GetSymptoms() == "Dizziness") // If the patient's symptoms are dizziness
    {
      if (patient.GetMedicalHistory() == "Diabetes") // If the patient has a medical history of diabetes
      {
        patient.SetPrescription("metformin " + GetDosage("metformin")); // Then prescribe metformin to the patient.
      }
      else
      {
        patient.SetPrescription("dimenhydrinate " + GetDosage("dimenhydrinate")); // Otherwise, prescribe dimenhydrinate to the patient.
      }
    }

    // This method returns the dosage of the medicine based on the patient's age and medicine name passed as an argument.
    string GetDosage(string medicineName)
    {
      if (medicineName == "ibuprofen") // If the medicine name is ibuprofen
      {
        if (patient.GetAge() < 18) // If the patient's age is less than 18
          return "400 mg"; // Then the dosage is 400 mg.
        else
          return "800 mg"; // Otherwise, the dosage is 800 mg.
      }
      else if (medicineName == "diphenhydramine") // If the medicine name is diphenhydramine
      {
        if (patient.GetAge() < 18) // If the patient's age is less than 18
          return "50 mg"; // Then the dosage is 50 mg.
        else
          return "300 mg"; // Otherwise, the dosage is 300 mg.
      }
      else if (medicineName == "dimenhydrinate") // If the medicine name is dimenhydrinate
      {
        if (patient.GetAge() < 18) // If the patient's age is less than 18
          return "50 mg"; // Then the dosage is 50 mg.
        else
          return "400 mg"; // Otherwise, the dosage is 400 mg.
      }
      else if (medicineName == "metformin") // If the medicine name is metformin
      {
        return "500 mg"; // Then the dosage is 500 mg.
      }
      return "Unknown";
    }
  }

  public static string GetBotName()
  {
    return MedicalBot.BotName;
  }
}



// This class represents a Patient object with various fields and methods to get and set the patient details.

class Patient
{
  // Private fields to store patient name, age, gender, medical history, symptom code, and prescription
  private string name;
  private int age;
  private string gender;
  private string medicalHistory;
  private string symptomCode;
  private string prescription;

  // Public method to get the patient name
  public string GetName()
  {
    return name;
  }

  // Public method to set the patient name and validate it. Returns a bool indicating whether the name is valid or not, and an error message if it's invalid.
  public bool SetName(string name, out string errorMessage)
  {
    bool isValid;

    // Check if name is null or empty
    if (name == null || name.Length == 0)
    {
      isValid = false;
      errorMessage = "Patient name can't be blank";
      return isValid;
    }

    // Check if name has only one character
    else if (name.Length == 1)
    {
      isValid = false;
      errorMessage = "Patient name should contain at least two or more characters";
      return isValid;
    }

    // Name is valid, set the field and return true
    isValid = true;
    errorMessage = "";

    this.name = name;
    return isValid;
  }

  // Public method to get the patient age
  public int GetAge()
  {
    return age;
  }

  // Public method to set the patient age and validate it. Returns a bool indicating whether the age is valid or not, and an error message if it's invalid.
  public bool SetAge(int age, out string errorMessage)
  {
    bool isValid;

    // Check if age is negative
    if (age < 0)
    {
      isValid = false;
      errorMessage = "Patient age can't be negative";
      return isValid;
    }

    // Check if age is greater than 100
    else if (age > 100)
    {
      isValid = false;
      errorMessage = "Patient age can't be greater than 100";
      return isValid;
    }

    // Age is valid, set the field and return true
    isValid = true;
    errorMessage = "";

    this.age = age;
    return isValid;
  }

  // Public method to get the patient gender
  public string GetGender()
  {
    return gender;
  }

  // Public method to set the patient gender and validate it. Returns a bool indicating whether the gender is valid or not, and an error message if it's invalid.
  public bool SetGender(string gender, out string errorMessage)
  {
    bool isValid;

    // Check if gender is not "Male", "Female", or "Other"
    if (gender != "Male" && gender != "Female" && gender != "Other" && gender != "male" && gender != "female" && gender != "other")
    {
      isValid = false;
      errorMessage = "Patient gender should be either Male, Female or Other";
      return isValid;
    }

    // Gender is valid, set the field and return true
    isValid = true;
    errorMessage = "";

    this.gender = gender;
    return isValid;
  }

  // Public method to get the patient medical history
  public string GetMedicalHistory()
  {
    return medicalHistory;
  }

  // Public method to set the patient medical history
  public void SetMedicalHistory(string medicalHistory)
  {
    this.medicalHistory = medicalHistory;
  }


  // Method to get the patient's symptoms
  public string GetSymptoms()
  {
    string symptom;

    // Use a switch statement to determine the symptom based on the symptom code
    switch (symptomCode)
    {
      case "S1":
      case "s1": symptom = "Headache"; break;

      case "S2":
      case "s2": symptom = "Skin rashes"; break;

      case "S3":
      case "s3": symptom = "Dizziness"; break;

      default: symptom = "Unknown"; break;
    }

    return symptom;
  }

  // A method to set the patient's symptom code
  public bool SetSymptomCode(string symptomCode, out string errorMessage)
  {
    bool isValid;

    // Check if the symptom code is valid
    if (symptomCode != "S1" && symptomCode != "S2" && symptomCode != "S3" && symptomCode != "s1" && symptomCode != "s2" && symptomCode != "s3")
    {
      isValid = false;
      errorMessage = "Symptom Code should either be S1, S2, or S3.";
      return isValid;
    }

    isValid = true;
    errorMessage = "";

    // Set the symptom code for the patient
    this.symptomCode = symptomCode;
    return isValid;
  }


  // A method to get the patient's prescription
  public string GetPrescription()
  {
    return prescription;
  }


  // A method to set the patient's prescription
  public void SetPrescription(string prescription)
  {
    this.prescription = prescription;
  }
}


class Program
{
  static void Main()
  {
    // Welcome message
    System.Console.WriteLine("Hi, I'm " + MedicalBot.GetBotName() + ". I'm here to help you in your medication.");
    System.Console.WriteLine("Enter your (patient) details:");

    // Create a new patient
    Patient patient = new Patient();

    // Read patient details and validate them
    System.Console.Write("Enter Patient Name: ");
    while (!patient.SetName(System.Console.ReadLine(), out string errorMessage))
    {
      Console.WriteLine(errorMessage);
      System.Console.Write("Enter Patient Name: ");
    }

    System.Console.Write("Enter Patient Age: ");
    while (!patient.SetAge(Convert.ToInt32(System.Console.ReadLine()), out string errorMessage))
    {
      Console.WriteLine(errorMessage);
      System.Console.Write("Enter Patient Age: ");
    }

    System.Console.Write("Enter Patient Gender: ");
    while (!patient.SetGender(System.Console.ReadLine(), out string errorMessage))
    {
      Console.WriteLine(errorMessage);
      System.Console.Write("Enter Patient Gender: ");
    }

    System.Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None: ");
    patient.SetMedicalHistory(System.Console.ReadLine());

    // Display patient details
    System.Console.WriteLine($"\nWelcome, " + patient.GetName() + ", " + patient.GetAge() + ".");
    System.Console.WriteLine("Which of the following symptoms do you have:");
    System.Console.WriteLine("S1. Headache");
    System.Console.WriteLine("S2. Skin rashes");
    System.Console.WriteLine("S3. Dizziness");

    // Read patient's symptom code and validate it
    System.Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
    while (!patient.SetSymptomCode(System.Console.ReadLine(), out string errorMessage))
    {
      Console.WriteLine(errorMessage);
      System.Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
    }

    // Create a new MedicalBot and prescribe medication for the patient
    MedicalBot doctorBot = new MedicalBot();
    doctorBot.PrescribeMedication(patient);

    // Display the prescription for the patient
    System.Console.WriteLine("\nYour prescription based on your age, symptoms and medical history:");
    System.Console.WriteLine(patient.GetPrescription());

    // Goodbye message
    System.Console.WriteLine("\nThank you for coming.");
    System.Console.ReadKey();
  }
}