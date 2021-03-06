﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity {
	public Vector2 position;
	public float rotation;
	public Vector2 scale;
	public bool dive;

	public Entity(Vector2 position, float rotation, Vector2 scale, bool dive){
		this.position = position;
		this.rotation = rotation;
		this.scale = scale;
		this.dive = dive;
	}

	public Entity GetClone(Entity entity) {
		if (entity == null)
			entity = new Entity (new Vector2(), 0, new Vector2(), false);
		if (entity.position == null)
			entity.position = new Vector2 ();
		entity.position.x = this.position.x;
		entity.position.y = this.position.y;
		entity.rotation = this.rotation;
		entity.scale = this.scale;
		entity.dive = this.dive;
		return entity;
	}

    public void diveChange(Entity entity)
    {
        dive = !dive;
    }
}
