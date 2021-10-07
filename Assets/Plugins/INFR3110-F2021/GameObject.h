#pragma once
#ifndef __GAME_OBJECT__
#define __GAME_OBJECT__

#include "Vector2D.h"
#include "PluginSettings.h"

class PLUGIN_API GameObject
{
public:
	//Constructor
	GameObject();

	//Getters and Setters
	int GetID() const;
	void SetID(int id = 0);

	Vector2D GetPosition() const;
	void SetPosition(float x = 0.0f, float y = 0.0f);
	Vector2D GetScale() const;
	void SetBossStats(float x = 0.0f, float y = 0.0f, float speed = 13.15f);


private:
	int m_id;
	Vector2D m_position;
	Vector2D m_scale;
	float m_speed;
};

#endif /* defined (__GAME_OBJECT__) */

