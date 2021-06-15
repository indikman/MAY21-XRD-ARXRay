Shader "Custom/Transparent"
{
    SubShader
    {
        Tags { "Queue" = "Transparent+1" } // 3001 transpatent queue
        
        Pass { Blend Zero One }
    }
}
