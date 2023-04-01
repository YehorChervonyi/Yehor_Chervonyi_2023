namespace LiskovSubstitution;

public class WorkingWithFile : IWorkingWithFile
{
 public Guid CheckUser(Guid user)
 {
  //Checking for user in db
  return user;
 }

 public Guid CheckRole(Guid role)
 {
  //Checking for user role
  return role;
 }

 public string ReadFromFile(string filename)
 {
  //Reading from file
  return ""; //Some text in file
 }

 public void WriteToFile(string filename)
 {
  //Write to file
 }

 public void DeleteFile(string filename)
 {
  //Delete file
 }

 public void DownloadFile(string filename)
 {
  //Download file
 }

 public void CopyFile(string filename)
 {
  //Copy file
 }

 public void GetDataFromFile(string filename)
 {
  //Get data from file
 }

 public void CheckFile(string filename)
 {
  //Check file
 }

 public void SaveToFile(string filename)
 {
  //Save to file
 }
}