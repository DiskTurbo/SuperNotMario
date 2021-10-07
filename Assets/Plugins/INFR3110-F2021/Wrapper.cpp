#include "Wrapper.h"
#include "GameObject.h"

GameObject gameObject;

PLUGIN_API int GetID()
{
    return gameObject.GetID();
}

PLUGIN_API void SetID(const int id)
{
    gameObject.SetID(id);
}

PLUGIN_API Vector2D GetPosition()
{
    return gameObject.GetPosition();
}

PLUGIN_API void SetPosition(const float x, const float y)
{
    gameObject.SetPosition(x, y);
}

PLUGIN_API Vector2D GetScale()
{
    return gameObject.GetScale();
}

PLUGIN_API void SetBossStats(const float x, const float y, const float speed)
{
    gameObject.SetBossStats(x, y, speed);
}
