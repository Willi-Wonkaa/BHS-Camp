using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    public PlayerFullScript player_full_script;
    public Animator _animator;
    private Rigidbody2D _body;
    private Ground _ground;
    private Controller _controller;

    private float _inputX;

    private int prev_hp;
    private int cur_hp;

    private bool is_get_damage;


    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _body = GetComponent<Rigidbody2D>();
        _ground = GetComponent<Ground>();
        _controller = GetComponent<Controller>();
        player_full_script = GetComponent<PlayerFullScript>();

        prev_hp = player_full_script.hp_current;
    }

    private void Update()
    {

        cur_hp = player_full_script.hp_current;
        is_get_damage = IsGetDamage(cur_hp, prev_hp);
        prev_hp = cur_hp;
        



        _inputX = _controller.input.RetrieveMoveInput();
        if (_inputX != 0)
            transform.localScale = new Vector2(
                Mathf.Sign(_inputX) * Mathf.Abs(transform.localScale.x),
                transform.localScale.y
            );

        _animator.SetFloat("VelocityX", Mathf.Abs(_body.velocity.x));
        _animator.SetFloat("VelocityY", _body.velocity.y);
        _animator.SetBool("IsJumping", !_ground.OnGround);
        _animator.SetBool("GetDamage", is_get_damage);
        _animator.SetInteger("HP", cur_hp);
    }



    public bool IsGetDamage(int hp, int prev_hp)
    {
        return !(hp == prev_hp);
    }
}