Shader "Custom/VignetteShader"
{
    Properties
    {
        _MainTex("Texture", 2D) = "white" {}
        _Vector("Vector", Vector) = (1,0,0,0)
        _Intensity("Intensity", Range(0, 1)) = 0.5
        _Radius("Radius", Range(0, 1)) = 0.5
    }

    SubShader
    {
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _Vector;
            float _Intensity;
            float _Radius;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                // Sample the texture
                fixed4 col = tex2D(_MainTex, i.uv);

                // Calculate the distance from the center of the screen
                float2 center = float2(0.5, 0.5);
                float2 uv = (i.uv - center) * 2;
               


                // Apply the vignette
                col.rgb *= intensity;

                return col;
            }
            ENDCG
        }
    }
}