package md5b9dbb8ec24b97e67d95a1576873b4bbc;


public class GPSServiceConnection
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.content.ServiceConnection
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onServiceConnected:(Landroid/content/ComponentName;Landroid/os/IBinder;)V:GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler:Android.Content.IServiceConnectionInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"n_onServiceDisconnected:(Landroid/content/ComponentName;)V:GetOnServiceDisconnected_Landroid_content_ComponentName_Handler:Android.Content.IServiceConnectionInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("NoClick.GPSServiceConnection, NoClick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", GPSServiceConnection.class, __md_methods);
	}


	public GPSServiceConnection () throws java.lang.Throwable
	{
		super ();
		if (getClass () == GPSServiceConnection.class)
			mono.android.TypeManager.Activate ("NoClick.GPSServiceConnection, NoClick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public GPSServiceConnection (md5b9dbb8ec24b97e67d95a1576873b4bbc.GPSServiceBinder p0) throws java.lang.Throwable
	{
		super ();
		if (getClass () == GPSServiceConnection.class)
			mono.android.TypeManager.Activate ("NoClick.GPSServiceConnection, NoClick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "NoClick.GPSServiceBinder, NoClick, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public void onServiceConnected (android.content.ComponentName p0, android.os.IBinder p1)
	{
		n_onServiceConnected (p0, p1);
	}

	private native void n_onServiceConnected (android.content.ComponentName p0, android.os.IBinder p1);


	public void onServiceDisconnected (android.content.ComponentName p0)
	{
		n_onServiceDisconnected (p0);
	}

	private native void n_onServiceDisconnected (android.content.ComponentName p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
