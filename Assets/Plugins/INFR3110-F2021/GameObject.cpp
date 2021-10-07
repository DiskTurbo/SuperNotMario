#include "GameObject.h"

GameObject::GameObject()
{
	SetID();
	SetPosition();
}

int GameObject::GetID() const
{
	return m_id;
}

void GameObject::SetID(const int id)
{
	m_id = id;
}

Vector2D GameObject::GetPosition() const
{
	return m_position;
}

void GameObject::SetPosition(const float x, const float y)
{
	m_position.x = x;
	m_position.y = y;
}

Vector2D GameObject::GetScale() const
{
	return m_scale;
}

void GameObject::SetBossStats(const float x, const float y, const float speed)
{
	m_scale.x = x * 2;
	m_scale.y = y * 2;
	m_speed = speed * 2;
}

