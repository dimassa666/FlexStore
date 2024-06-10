Shader "Custom/PortalMask"
{

    SubShader
{
    ZWrite off
    Cull off
    ColorMask 0

    Stencil{
        Ref 1
        Pass replace
    }
    
        Pass
        {
        
        }
    }
}