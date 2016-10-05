package com.buffu.edu.botobuffu;

import android.content.Context;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class BotoBuffu extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_boto_buffu);

        //Buscar el component, importar la classe Button
        Button boto=(Button) findViewById(R.id.buttonApreta);

        //Importa OnClickListener
        boto.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //Buscar el context, cal importar la classe
                Context context=getApplicationContext();

                Toast toast= Toast.makeText(context, "Has apretat el botó!", Toast.LENGTH_LONG);
                toast.show();
            }
        });


    }
}
