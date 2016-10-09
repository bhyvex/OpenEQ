Types
=====

- string -- 7-bit encoded length followed by utf-8 bytes
- vecX -- vector of floats
- intvecX -- vector of 32-bit integers

Structure
=========

- uint32 material_count
    - uint32 flags
    - string texturename
- uint32 object_count -- First is always the zone itself
    - string name
    - uint32 meshes
        - uint32 material_id
        - uint32 vertices
            - vec3 vertex
            - vec3 normal
            - vec2 texcoord
        - uint32 polygons [arrays in sequence.  one array of intvec3s, one array of bools]
            - intvec3 indices
            - bool collidable