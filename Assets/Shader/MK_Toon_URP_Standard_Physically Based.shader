Shader "MK/Toon/URP/Standard/Physically Based" {
	Properties {
		[Enum(MK.Toon.Workflow)] _Workflow ("", Float) = 0
		[Enum(MK.Toon.Surface)] _Surface ("", Float) = 0
		_Blend ("", Float) = 0
		[Toggle] _AlphaClipping ("", Float) = 0
		[Enum(MK.Toon.RenderFace)] _RenderFace ("", Float) = 2
		_AlbedoColor ("", Vector) = (1,1,1,1)
		_AlphaCutoff ("", Range(0, 1)) = 0.5
		_AlbedoMap ("", 2D) = "white" {}
		_AlbedoMapIntensity ("", Range(0, 1)) = 1
		[MKToonColorRGB] _SpecularColor ("", Vector) = (0.203125,0.203125,0.203125,1)
		_SpecularMap ("", 2D) = "white" {}
		_Metallic ("", Range(0, 1)) = 0
		_MetallicMap ("", 2D) = "white" {}
		_RoughnessMap ("", 2D) = "white" {}
		_Smoothness ("", Range(0, 1)) = 0.5
		_Roughness ("", Range(0, 1)) = 0.5
		_NormalMapIntensity ("", Float) = 1
		[Normal] _NormalMap ("", 2D) = "bump" {}
		_Parallax ("", Range(0, 0.1)) = 0
		_HeightMap ("", 2D) = "white" {}
		[Enum(MK.Toon.LightTransmission)] _LightTransmission ("", Float) = 0
		_LightTransmissionDistortion ("", Range(0, 1)) = 0.25
		[MKToonColorRGB] _LightTransmissionColor ("", Vector) = (1,0.65,0,1)
		_ThicknessMap ("", 2D) = "white" {}
		_OcclusionMapIntensity ("", Range(0, 1)) = 1
		_OcclusionMap ("", 2D) = "white" {}
		_EmissionColor ("", Vector) = (0,0,0,1)
		_EmissionMap ("", 2D) = "black" {}
		[Enum(MK.Toon.DetailBlend)] _DetailBlend ("", Float) = 0
		[MKToonColorRGB] _DetailColor ("", Vector) = (1,1,1,1)
		_DetailMix ("", Range(0, 1)) = 0.5
		_DetailMap ("", 2D) = "white" {}
		_DetailNormalMapIntensity ("", Float) = 1
		[Normal] _DetailNormalMap ("", 2D) = "bump" {}
		[Enum(MK.Toon.Light)] _Light ("", Float) = 1
		_DiffuseRamp ("", 2D) = "grey" {}
		_DiffuseSmoothness ("", Range(0, 1)) = 0
		_DiffuseThresholdOffset ("", Range(0, 1)) = 0.25
		_SpecularRamp ("", 2D) = "grey" {}
		_SpecularSmoothness ("", Range(0, 1)) = 0
		_SpecularThresholdOffset ("", Range(0, 1)) = 0.25
		_RimRamp ("", 2D) = "grey" {}
		_RimSmoothness ("", Range(0, 1)) = 0.5
		_RimThresholdOffset ("", Range(0, 1)) = 0.25
		_LightTransmissionRamp ("", 2D) = "grey" {}
		_LightTransmissionSmoothness ("", Range(0, 1)) = 0.5
		_LightTransmissionThresholdOffset ("", Range(0, 1)) = 0.25
		[MKToonLightBands] _LightBands ("", Range(2, 12)) = 4
		_LightBandsScale ("", Range(0, 1)) = 0.5
		_LightThreshold ("", Range(0, 1)) = 0.5
		_ThresholdMap ("", 2D) = "gray" {}
		_ThresholdMapScale ("", Float) = 1
		_GoochRampIntensity ("", Range(0, 1)) = 0.5
		_GoochRamp ("", 2D) = "white" {}
		_GoochBrightColor ("", Vector) = (1,1,1,1)
		_GoochBrightMap ("", 2D) = "white" {}
		_GoochDarkColor ("", Vector) = (0,0,0,1)
		_GoochDarkMap ("", 2D) = "white" {}
		_Contrast ("", Float) = 1
		[MKToonSaturation] _Saturation ("", Float) = 1
		[MKToonBrightness] _Brightness ("", Float) = 1
		[Enum(MK.Toon.Iridescence)] _Iridescence ("", Float) = 0
		_IridescenceRamp ("", 2D) = "white" {}
		_IridescenceSize ("", Range(0, 5)) = 1
		_IridescenceColor ("", Vector) = (1,1,1,0.5)
		_IridescenceSmoothness ("", Range(0, 1)) = 0.5
		_IridescenceThresholdOffset ("", Range(0, 1)) = 0
		[Enum(MK.Toon.Rim)] _Rim ("", Float) = 0
		_RimSize ("", Range(0, 5)) = 1
		_RimColor ("", Vector) = (1,1,1,1)
		_RimBrightColor ("", Vector) = (1,1,1,1)
		_RimDarkColor ("", Vector) = (0,0,0,1)
		[Enum(MK.Toon.ColorGrading)] _ColorGrading ("", Float) = 0
		[Toggle] _VertexAnimationStutter ("", Float) = 0
		[Enum(MK.Toon.VertexAnimation)] _VertexAnimation ("", Float) = 0
		_VertexAnimationIntensity ("", Range(0, 1)) = 0.05
		_VertexAnimationMap ("", 2D) = "white" {}
		_NoiseMap ("", 2D) = "white" {}
		[MKToonVector3Drawer] _VertexAnimationFrequency ("", Vector) = (2.5,2.5,2.5,1)
		[Enum(MK.Toon.Dissolve)] _Dissolve ("", Float) = 0
		_DissolveMapScale ("", Float) = 1
		_DissolveMap ("", 2D) = "white" {}
		_DissolveAmount ("", Range(0, 1)) = 0.5
		_DissolveBorderSize ("", Range(0, 1)) = 0.25
		_DissolveBorderRamp ("", 2D) = "white" {}
		[HDR] _DissolveBorderColor ("", Vector) = (1,1,1,1)
		[Enum(MK.Toon.Artistic)] _Artistic ("", Float) = 0
		[Enum(MK.Toon.ArtisticProjection)] _ArtisticProjection ("", Float) = 0
		_ArtisticFrequency ("", Range(1, 10)) = 1
		_DrawnMapScale ("", Float) = 1
		_DrawnMap ("", 2D) = "white" {}
		_DrawnClampMin ("", Range(0, 1)) = 0
		_DrawnClampMax ("", Range(0, 1)) = 1
		_HatchingMapScale ("", Float) = 1
		_HatchingBrightMap ("", 2D) = "white" {}
		_HatchingDarkMap ("", 2D) = "Black" {}
		_SketchMapScale ("", Float) = 1
		_SketchMap ("", 2D) = "black" {}
		[Enum(MK.Toon.Outline)] _Outline ("", Float) = 3
		[Enum(MK.Toon.OutlineData)] _OutlineData ("", Float) = 0
		_OutlineFadeMin ("", Float) = 0.25
		_OutlineFadeMax ("", Float) = 2
		_OutlineMap ("", 2D) = "white" {}
		_OutlineSize ("", Float) = 5
		_OutlineColor ("", Vector) = (0,0,0,1)
		_OutlineNoise ("", Range(-1, 1)) = 0
		[Enum(MK.Toon.BlendFactor)] [HideInInspector] _BlendSrc ("", Float) = 1
		[Enum(MK.Toon.BlendFactor)] [HideInInspector] _BlendDst ("", Float) = 0
		[Enum(MK.Toon.BlendFactor)] [HideInInspector] _BlendSrcAlpha ("", Float) = 1
		[Enum(MK.Toon.BlendFactor)] [HideInInspector] _BlendDstAlpha ("", Float) = 0
		[Enum(MK.Toon.ZWrite)] _ZWrite ("", Float) = 1
		[Enum(MK.Toon.ZTest)] _ZTest ("", Float) = 4
		[Enum(MK.Toon.Diffuse)] _Diffuse ("", Float) = 0
		[Toggle] _WrappedLighting ("", Float) = 1
		_IndirectFade ("", Range(0, 1)) = 1
		[Toggle] _ReceiveShadows ("", Float) = 1
		[Enum(MK.Toon.Specular)] _Specular ("", Float) = 1
		[MKToonSpecularIntensity] _SpecularIntensity ("", Float) = 1
		_Anisotropy ("", Range(-1, 1)) = 0
		[MKToonTransmissionIntensity] _LightTransmissionIntensity ("", Float) = 1
		[Enum(MK.Toon.EnvironmentReflection)] _EnvironmentReflections ("", Float) = 2
		[Toggle] _FresnelHighlights ("", Float) = 0
		[MKToonRenderPriority] _RenderPriority ("", Range(-50, 50)) = 0
		[Enum(MK.Toon.Stencil)] _Stencil ("", Float) = 1
		[MKToonStencilRef] _StencilRef ("", Range(0, 255)) = 0
		[MKToonStencilReadMask] _StencilReadMask ("", Range(0, 255)) = 255
		[MKToonStencilWriteMask] _StencilWriteMask ("", Range(0, 255)) = 255
		[Enum(MK.Toon.StencilComparison)] _StencilComp ("", Float) = 8
		[Enum(MK.Toon.StencilOperation)] _StencilPass ("", Float) = 0
		[Enum(MK.Toon.StencilOperation)] _StencilFail ("", Float) = 0
		[Enum(MK.Toon.StencilOperation)] _StencilZFail ("", Float) = 0
		[HideInInspector] _Initialized ("", Float) = 0
		[HideInInspector] _OptionsTab ("", Float) = 1
		[HideInInspector] _InputTab ("", Float) = 1
		[HideInInspector] _StylizeTab ("", Float) = 0
		[HideInInspector] _AdvancedTab ("", Float) = 0
		[HideInInspector] _Cutoff ("", Range(0, 1)) = 0.5
		[HideInInspector] _MainTex ("", 2D) = "white" {}
		[HideInInspector] _Color ("", Vector) = (1,1,1,1)
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		sampler2D _MainTex;
		fixed4 _Color;
		struct Input
		{
			float2 uv_MainTex;
		};
		
		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			fixed4 c = tex2D(_MainTex, IN.uv_MainTex) * _Color;
			o.Albedo = c.rgb;
			o.Alpha = c.a;
		}
		ENDCG
	}
	//CustomEditor "MK.Toon.Editor.URP.StandardPBSEditor"
}