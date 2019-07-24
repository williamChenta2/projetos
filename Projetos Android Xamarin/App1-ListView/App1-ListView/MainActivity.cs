using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace App1_ListView
{
    [Activity(Label = "App1_ListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<string> mItens;
        private ListView mListView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.myListView);

            mItens = new List<string>();
            mItens.Add("Bob");
            mItens.Add("Tom");
            mItens.Add("Jim");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItens);

            mListView.Adapter = adapter;
        }
    }
}

