#pragma once
#ifndef __WRAPPER__
#define __WRAPPER__

#include "PluginSettings.h"
#include "Vector2D.h"

#ifdef __cplusplus
extern "C"
{
#endif

	PLUGIN_API int GetID();

	PLUGIN_API void SetID(int id);

	PLUGIN_API Vector2D GetPosition();

	PLUGIN_API void SetPosition(float x, float y);

	PLUGIN_API Vector2D GetScale();

	PLUGIN_API void SetBossStats(float x, float y, float speed);

#ifdef __cplusplus
}
#endif

#endif /* defined (__WRAPPER__) */

