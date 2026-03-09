using System;
using System.Collections.Generic;
using KPFCore;
using KWCore.Utils;
using UnityEngine;

public class KPFBootstrap : MonoSingleton<KPFBootstrap>
{
	private Dictionary<Type, IRepository> m_repositories;

	private Dictionary<Type, IService> m_services;

	[SerializeField]
	private MasterConfig m_masterConfig;

	[Header("Optional Controllers")]
	[SerializeField]
	private ControllerBase[] m_controllers;

	protected override void Init()
	{
	}

	private void Start()
	{
	}

	private void InitialiseControllers()
	{
	}

	public T RegisterRepository<T>(IRepository repository) where T : IRepository
	{
		return default(T);
	}

	public T GetRepository<T>() where T : IRepository
	{
		return default(T);
	}

	public T RegisterService<T>() where T : IService, new()
	{
		return default(T);
	}
}
