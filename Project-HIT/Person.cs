using Project_HIT;
using Project_HIT.Screens;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


struct DOB
{
	int day;
	int month;
	int year;
}

abstract public class Person
{
	int id;
	int age;
	string profileImage = "Default_Profile.jpg";
	string name;
	string address;
	DOB dob;
	bool hasSignature = false;
	string signatureFile;


	public int Id { get => id; set => id = value; }
	public int Age { get => age; set => age = value; }
	public string ProfileImage { get => profileImage; set => profileImage = value; }
	public string Name { get => name; set => name = value; }
	public string Address { get => address; set => address = value; }
	public bool HasSignature { get => hasSignature; set => hasSignature = value; }
	internal DOB Dob { get => dob; set => dob = value; }

	public bool hasSignatureFile()
	{

		string fileName = this.Id.ToString() + ".bmp";
		string workingDirectory = Environment.CurrentDirectory;
		string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Signatures\\");

		if (File.Exists(path + fileName))
		{
			this.HasSignature = true;
		}

		return File.Exists(path + fileName);
	}


	public void ProfilePictureInit(string path, PictureBox pb)
	{

		if (File.Exists(path + this.Id.ToString() + ".bmp"))
		{
			this.ProfileImage = this.Id.ToString() + ".bmp";
		}

		if (!(this.ProfileImage == null))
		{
			pb.Image = Image.FromFile(path + this.ProfileImage);
		}
	}


	public void signatureInit(string path, PictureBox pb)
	{

		this.hasSignatureFile();


		if (this.HasSignature)
		{

			pb.Image = Image.FromFile(path + this.Id.ToString() + ".bmp");
		}
		else
		{

			pb.Image = Image.FromFile(path + "Default.jpg");

		}

	}



    public void signatueUpdater(PictureBox signatue_picturebox)
    {

        string fileName = this.Id.ToString();
        string workingDirectory = Environment.CurrentDirectory;
        string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Resources\\Signatures\\");

		if(signatue_picturebox.Image != null) { 
        signatue_picturebox.Image.Dispose();
        }
        Form signature = new Signature(this);
        signature.ShowDialog();
        signatue_picturebox.Image = Image.FromFile(path + fileName + ".bmp");


    }

    public void UploadProfilePicture(string folder, PictureBox profilePicture)
    {
        string fileName = this.Id.ToString();
        string workingDirectory = Environment.CurrentDirectory;
        string path = System.IO.Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + folder);


        OpenFileDialog opnfd = new OpenFileDialog();
        opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
        if (opnfd.ShowDialog() == DialogResult.OK)
        {
            if (!(opnfd.FileName.Equals(path + this.Id.ToString() + ".bmp")))
            {
                profilePicture.Image.Dispose();
                File.Copy(opnfd.FileName, path + this.Id.ToString() + ".bmp", true);
            }
            profilePicture.Image = new Bitmap(opnfd.FileName);
        }
        this.ProfileImage = this.Id.ToString() + ".bmp";
    }

}
