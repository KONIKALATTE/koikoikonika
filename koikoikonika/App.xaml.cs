using Firebase.Database;
using Firebase.Storage;
namespace koikoikonika;

public partial class App : Application
{
    public static FirebaseClient client = new("https://productdb-793cb-default-rtdb.asia-southeast1.firebasedatabase.app/");
    public static FirebaseStorage storage = new("productdb-793cb.appspot.com");
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
