package com.buffu.edu.missatgealerta;

import android.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;

public class missatge_alerta extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_missatge_alerta);

        AlertDialog.Builder alert=new AlertDialog.Builder(this);
        alert.setMessage("Esta todo Buffu!!!");
        // boto, listener


        alert.setPositiveButton(android.R.string.ok, null);
        alert.setNegativeButton("Cancela", null);
        alert.show();
    }
}
